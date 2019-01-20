using ShopSimpleApplications.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSimpleApplications
{
    public partial class ShopForm : Form
    {

        private Shop aShop;
        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopSavebutton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(ShopNameTextBox.Text, ShopAddressrichTextBox.Text);
            MessageBox.Show("Shop created");
        }

        private void ProductSavebutton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product(ProductItemIdtexTBox.Text, ProductCompanyTextBox.Text, Convert.ToDouble( ProductQuantityTextBox.Text));
            string msgOut= aShop.Add(aProduct);
            MessageBox.Show(msgOut);
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            string information = "SHope name : " + aShop.Shope_name + Environment.NewLine + "Shope Address : " + aShop.Shope_address + Environment.NewLine;
            information += "Product/ItemID \t" + "Product Company \t" + "Product Quantity"+Environment.NewLine;
            foreach(Product aProduct in aShop.Products)
            {
                information += aProduct.Product_id + "\t" + aProduct.Product_name + "\t" + aProduct.Product_quentity+Environment.NewLine;
            }
            MessageBox.Show(information);
        }
    }
}
