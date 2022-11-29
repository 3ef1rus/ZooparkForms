using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using zoopark;

namespace ZooparkForms
{
    public partial class UserMenuForm : Form
    {
        Database database = new Database();
        Database databaseClone = new Database();
        List<Label> lables = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        int selectedRow;
        public UserMenuForm()
        {
            InitializeComponent();
        }

        private List<string> nameColumn()
        {
            var table = comboBoxTables.Text;
            string quaryColumnName = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' and COLUMN_NAME not LIKE '%id%'";
            SqlCommand command = new SqlCommand(quaryColumnName, databaseClone.getConnection());
            databaseClone.openConnection();

            List<string> name = new List<string>();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                name.Add(reader.GetString(0));
            }
            reader.Close();

            databaseClone.closeConnection();

            return name;
        }
        private void CreateColumns()
        {
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();  // удаление всех строк
            int count = dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                dataGridView1.Columns.RemoveAt(0);
            }
            List<string> name = nameColumn();

            for (int i = 0; i < name.Count; i++)
            {
                dataGridView1.Columns.Add("", name[i]);
            }
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {

            int length = CountColumns();
            object[] row1 = new object[length + 1];

            for (int i = 0; i <= length - 1; i++)
            {
                try
                {

                    row1.SetValue(record.GetString(i), i);
                }
                catch
                {
                    row1.SetValue(record.GetInt32(i).ToString(), i);
                }

            }
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dgw);
            dataGridViewRow.SetValues(row1);
            dgw.Rows.Add(dataGridViewRow);

        }
        private int CountColumns()
        {

            var table = comboBoxTables.Text;

            string quaryKolvo = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' and COLUMN_NAME not like '%id%'";

            SqlCommand command = new SqlCommand(quaryKolvo, databaseClone.getConnection());

            databaseClone.openConnection();

            int length;

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            length = reader.GetInt32(0);

            reader.Close();

            databaseClone.closeConnection();

            return length;
        }
        private string nameForSelect()
        {
            string column = "";
            List<string> name = nameColumn();
            for (int i = 0; i < name.Count; i++)
            {
                if (column == "")
                {
                    column = column + " [" + name[i] + "] ";
                }
                else { column = column + " , [" + name[i] + "] "; }
            }
            return column;
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            var table = comboBoxTables.Text;

            string quaryStr = $"select {nameForSelect()} from {table} ";

            SqlCommand command = new SqlCommand(quaryStr, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        private void UserMenuForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            createTextBox();
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            int length = CountColumns();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                for (int i = 0; i < length; i++)
                {
                    textBoxes[i].Text = row.Cells[i].Value.ToString();

                }

            }
        }
        private void bnt_refresh_Click(object sender, EventArgs e)
        {
            CreateColumns();
            createTextBox();
            RefreshDataGrid(dataGridView1);
        }
        private void createTextBox()
        {
            if (textBoxes.Count != 0)
            {
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    Controls.Remove(textBoxes[i]);
                    Controls.Remove(lables[i]);
                }
                textBoxes.Clear();
                lables.Clear();
            }
            int length = CountColumns();
            List<string> name = nameColumn();
            for (int i = 0; i < length; i++)
            {
                Label boofL = new Label
                {
                    Name = "lable_" + i,
                    Text = name[i],
                    Location = new Point(424, 446 + i * 26)
                };
                TextBox boofT = new TextBox
                {

                    Name = "textBox_" + i,
                    Location = new Point(524, 446 + i * 26),
                    Height = 20,
                    Width = 382
                };
                Controls.Add(boofL);
                Controls.Add(boofT);
                lables.Add(boofL);
                textBoxes.Add(boofT);
            }

        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string column = "";
            List<string> name = nameColumn();
            var table = comboBoxTables.Text;

            for (int i = 1; i < name.Count; i++)
            {
                if (column == "")
                {
                    column = column + " [" + name[i] + "] ";
                }
                else { column = column + " , [" + name[i] + " ] "; }
            }

            string searchquary = $"select {nameForSelect()} from {table} where concat ({column}) like '%" + textBoxSearch.Text + "%' ";

            SqlCommand command = new SqlCommand(searchquary, database.getConnection());

            database.getConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

            database.closeConnection();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            quarymenu frmQ = new quarymenu();
            frmQ.Show();
            this.Show();
        }             

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
