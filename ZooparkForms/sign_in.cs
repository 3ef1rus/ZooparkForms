using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zoopark;

namespace ZooparkForms
{
    public partial class sign_in : Form
    {
        Database database = new Database();
        public sign_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            textBoxPasswordR.PasswordChar = '*';
            textBoxLoginR.MaxLength = 50;
            textBoxPasswordR.MaxLength = 50;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            

            var login = textBoxLoginR.Text;
            var password = textBoxPasswordR.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Аккаунт не создан");
                return;
            }
            string quaryStr = $"insert into Users(login_user,password_user) values('{login}','{password}')";
            
            SqlCommand command= new SqlCommand(quaryStr,database.getConnection());

            database.openConnection();
            if (checkUser())

            {
                return;
            }
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан", "Успех");
                log_in frm_log = new log_in();
                this.Hide();
                frm_log.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            database.closeConnection();

        }

        private Boolean checkUser()
        {
            var loginUser = textBoxLoginR.Text;
            var passwordUser = textBoxPasswordR.Text;

            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table= new DataTable();
            string quarystr = $"select userID,login_user,password_user from Users where login_user='{loginUser}' and password_user='{passwordUser}'";

            SqlCommand command = new SqlCommand(quarystr,database.getConnection());
            adapter.SelectCommand= command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
