using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace E_commerce.Presentation_Layer
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homePage1.BringToFront();

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homePage1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            
            cart1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel productContanir = new Panel();
            productContanir.Margin = new Padding(12,0,0,20);
            productContanir.Size = new Size(176, 245);
            productContanir.BackColor = Color.WhiteSmoke;

            Panel ProductImage = new Panel();
            ProductImage.Size = new Size(150,156);
            ProductImage.Location = new Point(11,19);
            ProductImage.BackgroundImage = Image.FromFile("D:\\Muneer\\E-commerce\\E-commerce\\Presentation_Layer\\photo\\product-1.png");
            ProductImage.BackgroundImageLayout = ImageLayout.Stretch;

            Label productName = new Label();
            productName.Text = "Swee Orange";
            productName.Font = new Font("MV Boli", 14, FontStyle.Bold);
            productName.Location = new Point(3,180);
            productName.Size=new Size(148,26);
            productName.ForeColor = Color.DimGray;

            Label productPrice = new Label();
            productPrice.Text = "75.00$";
            productPrice.ForeColor = Color.DimGray;
            productPrice.Font = new Font("MV Boli", 10, FontStyle.Bold);
            productPrice.Location = new Point(14,212);
            productPrice.Size = new Size(64,18);

            Button addButton = new Button();
            addButton.Text = "Add";
            addButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
            addButton.BackColor = Color.BlueViolet;
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(104,207);
            addButton.Size = new Size(64,30);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Cursor = Cursors.Hand;





            productContanir.Controls.Add(productName);
            productContanir.Controls.Add(productPrice);
            productContanir.Controls.Add(addButton);
            productContanir.Controls.Add(ProductImage);
            //flowLayoutPanel1.Controls.Add(productContanir);

            /*
            Button button = new Button();
            button.Text = "buttom";
            button.Margin = new Padding(20);
            flowLayoutPanel1.Controls.Add(button);
            */

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            payment1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            products1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            help1.BringToFront();
        }
        
        private void products1_Load(object sender, EventArgs e)
        {

        }
        
        private void payment1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cart1_Load(object sender, EventArgs e)
        {

        }

        private void help1_Load(object sender, EventArgs e)
        {

        }

        private void products1_Load_1(object sender, EventArgs e)
        {

        }

        private void products1_Load_2(object sender, EventArgs e)
        {

        }

        private void products2_Load(object sender, EventArgs e)
        {

        }

        private void products2_Load_1(object sender, EventArgs e)
        {
          
    
        }
        }
    }

