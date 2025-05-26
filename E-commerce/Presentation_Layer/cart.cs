using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace E_commerce.Presentation_Layer
{
    public partial class cart : UserControl
    {
        public cart()
        {
            InitializeComponent();
            displayProductsFromCart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void displayProductsFromCart()
        {
            Business_Layer.Product product = new Business_Layer.Product();
            int numberOfProduct = product.numberOfProduct();
            Panel[] panels = new Panel[numberOfProduct];
            MySqlDataReader allProducts = product.selectFromCart();
            int index = 0;
            int total = 0;
            int number = 0;
            while (allProducts.Read())
            {
                panels[index] = new Panel();
                panels[index].Margin = new Padding(12, 0, 0, 20);
                panels[index].Size = new Size(176, 245);
                panels[index].BackColor = Color.WhiteSmoke;
                number += 1;

                Panel ProductImage = new Panel();
                ProductImage.Size = new Size(150, 156);
                ProductImage.Location = new Point(11, 19);
                ProductImage.BackgroundImage = Image.FromFile("D:\\Muneer\\E-commerce\\E-commerce\\Presentation_Layer\\photo\\"+ allProducts.GetValue(3).ToString());
                //ProductImage.BackgroundImage = Image.FromFile(projrctPath + "\\Presentation_Layer\\photo\\" + allProducts.GetValue(2).ToString());
                ProductImage.BackgroundImageLayout = ImageLayout.Stretch;
                ProductImage.Tag = index;

                Label productName = new Label();
                productName.Text = allProducts.GetValue(1).ToString();
                productName.Font = new Font("MV Boli", 12, FontStyle.Bold);
                productName.Location = new Point(3, 180);
                productName.Size = new Size(170, 26);
                productName.ForeColor = Color.DimGray;

                Label productPrice = new Label();
                total += (int)allProducts.GetValue(2);
                productPrice.Text = allProducts.GetValue(2).ToString() + ".00$";
                productPrice.ForeColor = Color.DimGray;
                productPrice.Font = new Font("MV Boli", 9, FontStyle.Bold);
                productPrice.Location = new Point(14, 212);
                productPrice.Size = new Size(73, 18);
                productPrice.Tag= (int)allProducts.GetValue(2);


                Button addButton = new Button();
                addButton.Text = "Delete";
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
                    int price = (int)productPrice.Tag;
                    MessageBox.Show(id);
                    product.deleteFromCart(id);
                    number--;
                    total -= price;
                    productNO.Text = number.ToString();
                    TotalPrice.Text = total.ToString() + ".00$";
                    int number_product = (int)ProductImage.Tag;
                    panels[number_product].Visible = false;
                }

                panels[index].Controls.Add(productName);
                panels[index].Controls.Add(productPrice);
                panels[index].Controls.Add(addButton);
                panels[index].Controls.Add(ProductImage);
                flowLayoutPanel1.Controls.Add(panels[index]);
                index++;
            }
            productNO.Text = number.ToString();
            TotalPrice.Text = total.ToString()+".00$";
        }

        private void cart_Load(object sender, EventArgs e)
        {

        }
    }
}
