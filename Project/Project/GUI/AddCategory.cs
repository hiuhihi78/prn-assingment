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
    public partial class AddCategory : Form
    {
        Shop1Context context = new Shop1Context();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string category = txtName.Text;
            List<Category> categories = context.Categories.Where(c => c.Name == category).ToList();
            if(categories.Count > 0)
            {
                MessageBox.Show("This category was existed!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Add", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Category c = new Category();
                    c.Name = category;
                    context.Categories.Add(c);
                    context.SaveChanges();
                    MessageBox.Show("Add successfully!");
                    this.Close();
                }
            }
        }
    }
}
