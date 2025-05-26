using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce.Presentation_Layer
{
    public partial class signUp : UserControl
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Business_Layer.User user = new Business_Layer.User();
            if (passwordBox.Text == passwordBox2.Text)
            {
                if (user.validateSteing(emailBox.Text))
                {
                    user.insertUser(emailBox.Text, passwordBox.Text);
                    new home().Show();
                }
                else
                {
                    MessageBox.Show("format's email is wrong");
                }

            }
        }
    }
}
