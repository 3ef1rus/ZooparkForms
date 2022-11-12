using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using zoopark;

namespace ZooparkForms
{
    public partial class log_in : Form
    {

        Database database = new Database(); 
        public log_in()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }
        private void log_in_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar= '*';
            textBoxLogin.MaxLength=50;
            textBoxPassword.MaxLength=50;
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            var loginUser = textBoxLogin.Text;
            var passwordUser = textBoxPassword.Text;

            SqlDataAdapter adapter= new SqlDataAdapter(); 
            DataTable table= new DataTable();
            string quaryStr2 = $"select adminID, login_admin, password_admin from Admins where login_admin='{loginUser}' and password_admin='{passwordUser}'";
            string quaryStr = $"select userID, login_user, password_user from Users where login_user='{loginUser}' and password_user='{passwordUser}'";

            SqlCommand command = new SqlCommand(quaryStr2, database.getConnection()); 

            adapter.SelectCommand= command;
            adapter.Fill(table);

            if(table.Rows.Count == 1 ) 
            {
                MessageBox.Show("Вы вошли , админ", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminMenuForm frmA= new AdminMenuForm();
                this.Hide();
                frmA.ShowDialog();
                this.Show();
            }
           else
            {
                SqlCommand command2 = new SqlCommand(quaryStr, database.getConnection());

                adapter.SelectCommand = command2;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы вошли ", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserMenuForm frmU = new UserMenuForm();
                    this.Hide();
                    frmU.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Не существует", "Такого аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

        }

        private void linkLabelCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_in sing = new sign_in();
            this.Hide();
            sing.ShowDialog();
            this.Show();
        }
    }
}
