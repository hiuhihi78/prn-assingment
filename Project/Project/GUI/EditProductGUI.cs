using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI
{
    public partial class EditProductGUI : Form
    {
        int productId;
        Shop1Context context = new Shop1Context();
        public EditProductGUI(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            txtQuantity.Enabled = false;
            loadData();
        }

        void loadData()
        {
            Product product = context.Products.Find(productId);
            txtName.Text = product.Name;
            txtDes.Text = product.Description;
            txtCountry.Text = product.Country;
            txtQuantity.Text = product.Quantity.ToString();
            numPrice.Value = (int)product.Price;
            numDiscount.Value = (int)product.Discount;
            cboCategory.DataSource = context.Categories.ToList();
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "id";
            cboCategory.SelectedValue = product.CategoryId;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = context.Products.Find(productId);
            product.Name = txtName.Text;
            product.Description = txtDes.Text;
            product.Country = txtCountry.Text;
            product.Discount = (int)numDiscount.Value;
            product.Price = (int)numPrice.Value;
            product.Quantity = int.Parse(txtQuantity.Text);
            product.CategoryId = (int)cboCategory.SelectedValue;
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Edit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                context.Products.Update(product);
                context.SaveChanges();
            }
        }


        
    }
}
