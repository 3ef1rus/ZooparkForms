using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using zoopark;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

        int selectedRow;
        public AdminMenuForm()
        {
            InitializeComponent();
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

            var table = comboBoxTables.Text;
            string quaryColumnName = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'";
            SqlCommand command = new SqlCommand(quaryColumnName, databaseClone.getConnection());

                databaseClone.openConnection();


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    dataGridView1.Columns.Add("", reader.GetString(0));
                }

                dataGridView1.Columns.Add("IsNew", String.Empty);
                reader.Close();

                databaseClone.closeConnection();
            
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) 
        {

            int length = CountColumns();
            string[] row1 = new string[length];
            for (int i = 0;i<= length-1; i++)
            {
                try {
                    row1.SetValue(record.GetString(i),i);
                }
                catch {
                    row1.SetValue(record.GetInt32(i).ToString(), i);
                        }
                if (i == length)
                {
                    row1.SetValue(RowState.ModifiedNew, length);
                    break;
                }
            }
            dgw.Rows.Add(row1);
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
            RefreshDataGrid(dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow= e.RowIndex;

            if(e.RowIndex >=0)
            {
                DataGridViewRow row= dataGridView1.Rows[selectedRow];


                  textBox_ID.Text = row.Cells[0].Value.ToString();
                  textBox_FIO.Text = row.Cells[1].Value.ToString();
                  textBox_Salarity.Text = row.Cells[2].Value.ToString();
                  textBox_Sex.Text = row.Cells[3].Value.ToString();
                  textBox_Age.Text = row.Cells[4].Value.ToString();
                  textBox_Exp.Text = row.Cells[5].Value.ToString();
                  textBox_IDjobs.Text = row.Cells[6].Value.ToString();

            }
        }

        private void bnt_refresh_Click(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var FIO = textBox_FIO.Text;
            var Sal = textBox_Salarity.Text;
            var Sex = textBox_Sex.Text;
            var Age = textBox_Age.Text;
            var Exp = textBox_Exp.Text;
            var IDjobs = textBox_IDjobs.Text;

            var Addquary = $"insert into Employee ([Full name],Salarity,Sex,Age,Experience,jobID) values ('{FIO}','{Sal}','{Sex}','{Age}','{Exp}','{IDjobs}')";
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

            string searchquary = $"select * from Employee where concat (employeeID,[Full name],Salarity,Sex,Age,Experience,jobID) like '%" + textBoxSearch.Text + "%'";

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
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void updateTable()
        {
            database.openConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[7].Value;

                if (rowState == RowState.Existed) continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    
                    var deletequary = $"delete from Employee where employeeID ={id}";

                    SqlCommand command= new SqlCommand(deletequary,database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = textBox_ID.Text;
                    var FIO = textBox_FIO.Text;
                    var Sal = textBox_Salarity.Text;
                    var Sex = textBox_Sex.Text;
                    var Age = textBox_Age.Text;
                    var Exp = textBox_Exp.Text;
                    var IDjobs = textBox_IDjobs.Text;

                    var changequary = $"update Employee set [Full name] = '{FIO}', [Salarity] = '{Sal}', [Sex] = '{Sex}', [Age] = '{Age}', [Experience] = '{Exp}', [jobID] = '{IDjobs}' where employeeID = '{id}'";

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

            var FIO = textBox_FIO.Text;
            var Sal = textBox_Salarity.Text;
            var Sex = textBox_Sex.Text;
            var Age = textBox_Age.Text;
            var Exp = textBox_Exp.Text;
            var IDjobs = textBox_IDjobs.Text;

            if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString()!=string.Empty)
            {
                dataGridView1.Rows[selectRowIndex].SetValues(FIO, Sal, Sex, Age, Exp, IDjobs);
                dataGridView1.Rows[selectRowIndex].Cells[7].Value = RowState.Modified;
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
    }
}
