using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace E_commerce.Presentation_Layer
{
    public partial class products : UserControl
    {
        public products()
        {
            InitializeComponent();
            displayProducts();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void displayProducts()
        {
            Business_Layer.Product product = new Business_Layer.Product();
            MySqlDataReader allProducts = product.showProduts();
            while (allProducts.Read())
            {
                Panel productContanir = new Panel();
                productContanir.Margin = new Padding(12, 0, 0, 20);
                productContanir.Size = new Size(176, 245);
                productContanir.BackColor = Color.WhiteSmoke;
                productContanir.Tag = allProducts.GetValue(0).ToString();


                Panel ProductImage = new Panel();
                ProductImage.Size = new Size(150, 156);
                ProductImage.Location = new Point(11, 19);
                ProductImage.BackgroundImage = Image.FromFile("D:\\Muneer\\E-commerce\\E-commerce\\Presentation_Layer\\photo\\"+ allProducts.GetValue(3).ToString());
                //ProductImage.BackgroundImage = Image.FromFile(projrctPath + "\\Presentation_Layer\\photo\\" + allProducts.GetValue(3).ToString());
                ProductImage.BackgroundImageLayout = ImageLayout.Stretch;

                Label productName = new Label();
                productName.Text = allProducts.GetValue(1).ToString();
                productName.Font = new Font("MV Boli", 12, FontStyle.Bold);
                productName.Location = new Point(3, 180);
                productName.Size = new Size(170, 26);
                productName.ForeColor = Color.DimGray;

                Label productPrice = new Label();
                productPrice.Text = allProducts.GetValue(2).ToString() + ".00$";
                productPrice.ForeColor = Color.DimGray;
                productPrice.Font = new Font("MV Boli", 9, FontStyle.Bold);
                productPrice.Location = new Point(14, 212);
                productPrice.Size = new Size(73, 18);


                Button addButton = new Button();
                addButton.Text = "Add";
                addButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
                addButton.BackColor = Color.BlueViolet;
                addButton.ForeColor = Color.White;
                addButton.Location = new Point(104, 207);
                addButton.Size = new Size(64, 30);
                addButton.FlatStyle = FlatStyle.Flat;
                addButton.Cursor = Cursors.Hand;
                addButton.Tag = allProducts.GetValue(0).ToString();
                addButton.Click += addButton_Click;
                void addButton_Click(object sender, EventArgs e)
                {
                    Button clickedButton = (Button)sender;
                    string id = (string)addButton.Tag;
                    MessageBox.Show(id);
                    product.insertToCart(id);
                }

                productContanir.Controls.Add(productName);
                productContanir.Controls.Add(productPrice);
                productContanir.Controls.Add(addButton);
                productContanir.Controls.Add(ProductImage);
                flowLayoutPanel2.Controls.Add(productContanir);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
