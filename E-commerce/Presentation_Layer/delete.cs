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
    public partial class delete : UserControl
    {
        public delete()
        {
            InitializeComponent();
            displayProducts();
        }

        private void modify_Load(object sender, EventArgs e)
        {

        }

        void displayProducts()
        {
            Business_Layer.Product product = new Business_Layer.Product();
            int numberOfProduct = product.numberOfProduct();
            Panel[] panels = new Panel[numberOfProduct];
            int number = 0;
            MySqlDataReader allProducts = product.showProduts();
            while (allProducts.Read())
            {
                panels[number] = new Panel();
                panels[number].Margin = new Padding(12, 0, 0, 20);
                panels[number].Size = new Size(176, 245);
                panels[number].BackColor = Color.WhiteSmoke;


                Panel ProductImage = new Panel();
                ProductImage.Size = new Size(150, 156);
                ProductImage.Location = new Point(11, 19);
                ProductImage.BackgroundImage = Image.FromFile("D:\\Muneer\\E-commerce\\E-commerce\\Presentation_Layer\\photo\\" + allProducts.GetValue(3).ToString());
                ProductImage.BackgroundImageLayout = ImageLayout.Stretch;
                ProductImage.Tag = number;
               

                Label productName = new Label();
                productName.Text = allProducts.GetValue(1).ToString();
                productName.Font = new Font("MV Boli", 9, FontStyle.Bold);
                productName.Location = new Point(3, 180);
                productName.Size = new Size(170, 25);
                productName.ForeColor = Color.DimGray;
                

                Label productPrice = new Label();
                productPrice.Text = allProducts.GetValue(2).ToString() + ".00$";
                productPrice.ForeColor = Color.DimGray;
                productPrice.Font = new Font("MV Boli", 9, FontStyle.Bold);
                productPrice.Location = new Point(14, 212);
                productPrice.Size = new Size(73, 18);


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
                    string id_product = (string)addButton.Tag;
                    product.deleteProduct(id_product);
                    MessageBox.Show(id_product);
                    int number_product = (int)ProductImage.Tag;
                    panels[number_product].Visible = false;
                }

                panels[number].Controls.Add(productName);
                panels[number].Controls.Add(productPrice);
                panels[number].Controls.Add(addButton);
                panels[number].Controls.Add(ProductImage);
                flowLayoutPanel1.Controls.Add(panels[number]);
                number++;
            }
        }
    }
}
