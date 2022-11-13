using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooparkForms
{
    public partial class UserMenuForm : Form
    {
        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void UserMenuForm_Load(object sender, EventArgs e)
        {
           
        }
        /*private void createTextBox()
        {
            int length = 9;
            List<Label> lables = new List<Label>();
            List<TextBox> textBoxes = new List<TextBox>();
            for (int i = 0; i < length; i++)
            {
                Controls.Add(new Label { Name = "data" + + "_l", Location = new Point(), );


        lables.Add(new Label()
                {
                    Text = "&First Name",
                    Location = new Point(10, 10 + i * 10)
                });
                textBoxes.Add(new TextBox()
                {
                    Location = new Point(lables[i].Bounds.Right + Padding.Left, lables[i].Location.X),
                });

                
                Controls.Add(lables.ElementAt(i));
                Controls.Add(textBoxes.ElementAt(i));
            }

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
