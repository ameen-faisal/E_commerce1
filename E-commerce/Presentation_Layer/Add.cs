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

namespace E_commerce.Presentation_Layer
{
    public partial class Add : UserControl
    {
        string imageName;
        string imagePath;
        string targetPath;
        public Add()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string projrctPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            projrctPath = Directory.GetParent(projrctPath).FullName;
            MessageBox.Show(projrctPath.Replace("\\", "\\\\"));

            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            openFileDialog1.Filter = "Image File (*.JPG; *.PNG)|*.JPG; *.PNG";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                 imageName = openFileDialog1.SafeFileName;
                MessageBox.Show(imageName);

                targetPath = Path.Combine("D:\\Muneer\\E-commerce\\E-commerce\\Presentation_Layer\\photo", imageName);
                    
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = productNameBox.Text;
            string price = productPricBox.Text;
            File.Copy(imagePath, targetPath, true);
            Business_Layer.Product product= new Business_Layer.Product();
            product.insertProduct(name, price, imageName);
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
