using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using zoopark;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooparkForms
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }



    public partial class AdminMenuForm : Form
    {
        Database database=new Database();
        Database databaseClone = new Database();
        List<Label> lables = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        int selectedRow;
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private List<string> nameColumn()
        {
            var table = comboBoxTables.Text;
            string quaryColumnName = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'";
            SqlCommand command = new SqlCommand(quaryColumnName, databaseClone.getConnection());
            databaseClone.openConnection();
           
            List<string> name = new List<string>();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                name.Add( reader.GetString(0));
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
                dataGridView1.Columns.Add("IsNew", "State");                                      
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
                    try
                    {
                        row1.SetValue(record.GetInt32(i).ToString(), i);
                    }
                    catch
                    {
                          row1.SetValue(record.GetDateTime(i).ToString(), i);
                    }
                }
            }
            row1.SetValue(RowState.ModifiedNew, length);
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dgw);
            dataGridViewRow.SetValues(row1);
            dgw.Rows.Add(dataGridViewRow);

        }

        private int CountColumns() 
        {

            var table = comboBoxTables.Text;

            string quaryKolvo = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'";

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
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            var table = comboBoxTables.Text;
            string quaryStr = $"select * from {table}";           

            SqlCommand command = new SqlCommand(quaryStr, database.getConnection());
            
            database.openConnection();

            SqlDataReader reader= command.ExecuteReader();
                                   
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        
        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

            CreateColumns();
            createTextBox();
            RefreshDataGrid(dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow= e.RowIndex;
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
            DataGridView dgw= new DataGridView();
            for (int i = 0; i < length; i++)
            {
                Label boofL = new Label
                {
                    Name = "lable_" + i,
                    Text = name[i],
                    Location = new Point(btn_add.Location.X+btn_add.Width+50, (btn_add.Location.Y+10) + i * 26)
                };
                TextBox boofT = new TextBox
                {

                    Name = "textBox_" + i,
                    Location = new Point(boofL.Location.X+ boofL.Width+ 5, (boofL.Location.Y-7) + i),

                    Height = 20,
                    Width = 382,
                   
                };
                Controls.Add(boofL);
                Controls.Add(boofT);
                lables.Add(boofL);
                textBoxes.Add(boofT);
            }
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            database.openConnection();
            string values="";
            string column = "";
            var table = comboBoxTables.Text;
            for (int i = 1; i < textBoxes.Count; i++)
            {
                if (values == "") { 
                    values = values + " '" + textBoxes[i].Text + "' ";
                }
                else { values = values + " , '" + textBoxes[i].Text + "' "; }
                

            }

            List<string> name = nameColumn();
            for (int i = 1; i < name.Count; i++)
            {
                if (column == "")
                {
                    column = column + " [" + name[i] + "] ";
                }
                else { column = column + " , [" + name[i] +" ] "; }


            }
            var Addquary = $"insert into {table} ({column}) values ({values})";
            try
            {
                var command = new SqlCommand(Addquary, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлина");
            }
            catch
            {
                MessageBox.Show("Ошибка проверьте корректность ввода");
            }
            database.closeConnection();
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

            string searchquary = $"select * from {table} where concat ({column}) like '%" + textBoxSearch.Text + "%'";

            SqlCommand command = new SqlCommand(searchquary, database.getConnection());

            database.getConnection();

            SqlDataReader reader=command.ExecuteReader();

            while(reader.Read())
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

        private void removeRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible= false;
            
            if (dataGridView1.Rows[index].Cells[0].Value.ToString()==string.Empty)
            {
                dataGridView1.Rows[index].Cells[CountColumns()].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[CountColumns()].Value = RowState.Deleted;
        }

        private void updateTable()
        {
            database.openConnection();

            string update = "";

            var table = comboBoxTables.Text;
            var ID = nameColumn();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[CountColumns()].Value;

                if (rowState == RowState.Existed) continue;

                if (rowState == RowState.Deleted)
                {
                    
                    var deletequary = $"delete from {table} where {ID[0]} = '{textBoxes[0].Text}'";

                    SqlCommand command= new SqlCommand(deletequary,database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    
                    for (int j = 1; j < textBoxes.Count; j++)
                    {
                        if (update == "")
                        {
                            update = update + " [" + ID[j] + "] = '" + textBoxes[j].Text + "' ";
                        }
                        else
                        {
                            update = update + " , [" + ID[j] + "] = '" + textBoxes[j].Text + "' ";
                        }
                    }
                    var changequary = $"update {table} set {update} where {ID[0]} = '{textBoxes[0].Text}'";

                    var command = new SqlCommand(changequary, database.getConnection());
                    command.ExecuteNonQuery();
                     }
            }
            database.closeConnection();
        }
        private void btn_rem_Click(object sender, EventArgs e)
        {
            removeRow();
            updateTable();
        }

        private void Change()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;
  
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            object[] values = new object[CountColumns()];
            for (int i = 0; i < CountColumns(); i++)
            {
                values.SetValue(textBoxes[i].Text,i);
            }
            for (int i = 0; i < CountColumns(); i++)
            {
                textBoxes[i].Text = row.Cells[i].Value.ToString();
                if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[selectRowIndex].SetValues(values);
                    dataGridView1.Rows[selectRowIndex].Cells[CountColumns()].Value = RowState.Modified;
                }
            }

            
        }

        private void btn_chang_Click(object sender, EventArgs e)
        {
            Change();
            updateTable();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
