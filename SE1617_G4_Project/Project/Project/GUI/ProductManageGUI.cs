using Microsoft.EntityFrameworkCore;
using Project.Config;
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
    public partial class ProductManageGUI : Form
    {
        Shop1Context context = new Shop1Context();
        
        public ProductManageGUI()
        {
            
            InitializeComponent();
            

            Category all = new Category(0, "All category");
            List<Category> categories = context.Categories.ToList();
            categories.Add(all);
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "id";
            cboCategory.SelectedValue = 0;

            

            loadData();
        }

        void loadData()
        {

            staff staff = context.staff.Find(Setting.staffId);
            if (staff.IsManager)
            {
                linkLabel1.Visible = true;
            }
            else
            {
                linkLabel1.Visible = false;
            }

            dataGridView1.Columns.Clear();

            string name = txtName.Text;
            int price1 = (int)txtPrice1.Value;
            int price2 = (int)txtPrice2.Value;
            int category = (int)cboCategory.SelectedValue;
            List<Product> products = new List<Product>();
            if (category == 0)
            {
                products = context.Products.Include(p => p.Category)
                    .Where(p => p.Name.Contains(name) && p.Price >= price1 && p.Price <= price2)
                    .ToList();

            }
            else
            {
                products = context.Products.Include(p => p.Category)
                    .Where(p => p.Name.Contains(name) && p.Price >= price1 && p.Price <= price2 && p.CategoryId == category)
                    .ToList();
            }
            dataGridView1.DataSource = products;


            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Country"].Visible = false;
            dataGridView1.Columns["Category"].Visible = false;
            dataGridView1.Columns["ImportDetails"].Visible = false;
            dataGridView1.Columns["OrderDetails"].Visible = false;

            int countColums = dataGridView1.Columns.Count;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            if (staff.IsManager)
            {
                dataGridView1.Columns.Insert(countColums, btnEdit);
            }

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;


            if (staff.IsManager)
            {
                dataGridView1.Columns.Insert(countColums + 1, btnDelete);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                EditProductGUI form = new EditProductGUI(productId);
                form.ShowDialog();
                
            }

            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Product product = context.Products.Find(productId);

                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes) 
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                    loadData();
                }
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            AddProductGUI form = new AddProductGUI();
            form.ShowDialog();
            loadData();
        }
    }
}
