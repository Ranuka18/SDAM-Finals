using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Seller
{
    public partial class AddProductForm : Form
    {
        string imagePath = "";
        int sellerId;

        public AddProductForm(int id)
        {
            InitializeComponent();
            sellerId = id;
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                SellerId = sellerId, 
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                ImagePath = imagePath 
            };

            product.Save_btn();

            MessageBox.Show("Product added!");
        }

    }
}
