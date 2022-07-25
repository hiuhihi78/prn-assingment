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
    public partial class OrderGUI : Form
    {
        Shop1Context context = new Shop1Context();
        List<Product> products = Setting.products;
        

        public OrderGUI()
        {
            InitializeComponent();
            loadDataDataGirdView();
            loadDataPanel();
            loadDataLable();
            loadCheckoutButton();
            
        }


        void loadDataDataGirdView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = context.Products.Include(c => c.Category)
                .Select(p => new 
                {
                    Id = p.Id,
                    Name = p.Name,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    Discount = p.Discount,
                    Category = p.Category.Name
                }).
                ToList();
            dataGridView1.Columns["Id"].Visible = false;

            int countColums = dataGridView1.Columns.Count;
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
            btnAdd.Name = "Add";
            btnAdd.Text = "Add";
            btnAdd.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(countColums, btnAdd);
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index)
            {
                int productId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Product product = context.Products.Find(productId);

                bool isExisted = products.Where(p => p.Id == productId).Count() > 0;
                if(isExisted == true)
                {
                    Product p = products.Where(p => p.Id == productId).FirstOrDefault();
                    if(p.Quantity < product.Quantity && product.Quantity > 0)
                    {
                        p.Quantity = (p.Quantity + 1);
                    }
                }
                else
                {
                    if(product.Quantity > 0)
                    {
                        product.Quantity = 1;
                        products.Add(product);
                    }
                }


                loadDataPanel();
                loadDataLable();
                loadCheckoutButton();
            }
        }


        void loadCheckoutButton()
        {
            btnCheckout.Enabled = false;
            if (products.Count() > 0)
            {
                btnCheckout.Enabled = true;
            }
            else
            {
                btnCheckout.Enabled = false;
            }
        }
        private void OrderGUI_Activated(object sender, EventArgs e)
        {
            
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutGUI form = new CheckoutGUI();
            form.ShowDialog();
        }

       

        //pannel
        void loadDataPanel()
        {
            panel1.Controls.Clear();
            

            int location_w = 20;
            int loaction_h = 30;
            int margin_left = 20;
            int margin_buttom = 20;
            Label label;
            NumericUpDown numericUp;
            Button button;
            for (int i = 0; i < products.Count(); i++)
            {
                label = new Label();
                label.Text = products[i].Name;
                label.Location = new Point(location_w, loaction_h * i);


                numericUp = new NumericUpDown();
                numericUp.Name = $"num_{products[i].Id}";
                numericUp.Value = products[i].Quantity;
                numericUp.Location = new Point(label.Width + label.Location.X + margin_left, label.Location.Y);
                numericUp.Minimum = 1;
                numericUp.Maximum = 1000000;
                numericUp.ValueChanged += new EventHandler(numericUp_ValueChanged);


                button = new Button();
                button.Name = $"num_{products[i].Id}";
                button.Location = new Point(numericUp.Width + numericUp.Location.X + margin_left, numericUp.Location.Y);
                button.Text = "x";
                button.Width = 27;
                button.Height = 27;
                button.Click += new EventHandler(button_Click);

                panel1.Controls.Add(label);
                panel1.Controls.Add(numericUp);
                panel1.Controls.Add(button);
            }
        }

        private void numericUp_ValueChanged(object sender, EventArgs e)
        {
            List<Product> productMain = context.Products.ToList();
            NumericUpDown numericUp = sender as NumericUpDown;

            string raw_productId = numericUp.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId.Trim());

            int maxQuantity = productMain.Where(p => p.Id == productId).FirstOrDefault().Quantity;
            
            if (numericUp.Value > maxQuantity)
            {
                MessageBox.Show($"Quantity must be equal or less than {maxQuantity}");
                Product product = products.Where(p => p.Id == productId).FirstOrDefault();
                product.Quantity = maxQuantity;
                numericUp.Value = maxQuantity;
            }
            else
            {
                Product product = products.Where(p => p.Id == productId).FirstOrDefault();
                product.Quantity = (int)numericUp.Value;
            }
            loadDataPanel();
            loadDataLable();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string raw_productId = button.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId);
            
            Product product = products.Where(p => p.Id == productId).FirstOrDefault();
            products.Remove(product);
            loadDataPanel();
            loadDataLable();
            loadCheckoutButton();

        }

        void loadDataLable()
        {
            double total = 0;
            foreach(Product product in products)
            {
                if (product.Discount == 0)
                {
                    total = total + product.Quantity * product.Price;
                }
                else
                {
                    total = total + product.Quantity * product.Price - product.Quantity * product.Price * product.Discount / 100;
                }
            }
            lblTotal.Text = total.ToString();
        }

        private void OrderGUI_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderGUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
