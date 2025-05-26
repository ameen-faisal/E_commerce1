using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http.Headers;

namespace E_commerce.Presentation_Layer
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Business_Layer.User user= new Business_Layer.User();
            if(user.validateSteing(emailBox.Text))
            {
                if (user.showUser(emailBox.Text, passwordBox.Text))
                {
                    if(user.isAdmin(emailBox.Text, passwordBox.Text))
                    {
                        new admin().ShowDialog();
                    }
                    else
                    {
                        new home().ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Account not found");
                }
            }
            else
            {
                MessageBox.Show("format's email must contin on @ dot");
            }
            
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void emailBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
