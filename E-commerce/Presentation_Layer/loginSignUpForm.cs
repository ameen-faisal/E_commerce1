using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_commerce.Presentation_Layer
{
    public partial class loginSignUpForm : Form
    {
        public loginSignUpForm()
        {
            InitializeComponent();
            login1.BringToFront();



           /* string mysqlCon = "server=localhost; user=root; database=e-commerce; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("connection success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            */

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Font = new Font(button2.Font, FontStyle.Underline);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font, FontStyle.Regular);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Font = new Font(button1.Font, FontStyle.Underline);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUp1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login1.BringToFront();
        }

        private void loginSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void SignUp1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
