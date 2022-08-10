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
    public partial class AddProductGUI : Form
    {
        Shop1Context context = new Shop1Context();
        public AddProductGUI()
        {
            InitializeComponent();
            loadData();
        }


        void loadData()
        {
            cboCategory.DataSource = context.Categories.ToList();
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "id";
        }





        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Description = txtDes.Text;
            product.Country = txtCountry.Text;
            product.Discount = (int)numDiscount.Value;
            product.Price = (int)numPrice.Value;
            product.Quantity = (int)numQuantity.Value;
            product.CategoryId = (int)cboCategory.SelectedValue;
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Add", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                context.Products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Add successfully!");
                this.Close();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory form = new AddCategory();
            form.ShowDialog();
            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
