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
    public partial class CheckoutImportGUI : Form
    {
        Shop1Context context = new Shop1Context();
        List<Product> products = Setting.products_import;
        public CheckoutImportGUI()
        {
            InitializeComponent();
            loadData();
            loadDataLable();
        }


        void loadData()
        {
            panel1.Controls.Clear();
            int location_w = 20;
            int loaction_h = 30;
            int margin_left = 20;
            int margin_buttom = 20;
            Label label;
            NumericUpDown numericUp, numericUpPrice;
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


                numericUpPrice = new NumericUpDown();
                numericUpPrice.Name = $"num_{products[i].Id}";
                numericUpPrice.Value = products[i].Quantity;
                numericUpPrice.Location = new Point(numericUp.Width + numericUp.Location.X + margin_left, numericUp.Location.Y);
                numericUpPrice.Minimum = 1;
                numericUpPrice.Maximum = 10000000000;
                numericUpPrice.Value = (int)products[i].Price;
                numericUpPrice.ValueChanged += new EventHandler(numericUpPrice_ValueChanged);

                button = new Button();
                button.Name = $"num_{products[i].Id}";
                button.Location = new Point(numericUpPrice.Width + numericUpPrice.Location.X + margin_left, numericUpPrice.Location.Y);
                button.Text = "x";
                button.Width = 27;
                button.Height = 27;
                button.Click += new EventHandler(button_Click);

               

                panel1.Controls.Add(label);
                panel1.Controls.Add(numericUp);
                panel1.Controls.Add(numericUpPrice);
                panel1.Controls.Add(button);

            }
        }

        
        private void numericUp_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUp = sender as NumericUpDown;

            string raw_productId = numericUp.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId);

            int maxQuantity = context.Products.Find(productId).Quantity;
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
            loadDataLable();
            loadCheckoutButton();
        }

        private void numericUpPrice_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUp = sender as NumericUpDown;

            string raw_productId = numericUp.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId);

            Product product = products.Where(p => p.Id == productId).FirstOrDefault();
            product.Price = (double)numericUp.Value;

            loadDataLable();
            loadCheckoutButton();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string raw_productId = button.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId);
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Product product = products.Where(p => p.Id == productId).FirstOrDefault();
                products.Remove(product);
                loadData();
                loadDataLable();
                loadCheckoutButton();
            }

        }

        void loadDataLable()
        {
            double total = 0;
            foreach (Product product in products)
            {
                total = total + product.Quantity * product.Price;
            }
            lblTotal.Text = total.ToString();
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            

            Import import = new Import()
            {
                ImportDate = DateTime.Now,
                StaffId = Setting.staffId,
                TotalAmount = double.Parse(lblTotal.Text)
            };

            context.Imports.Add(import);
            context.SaveChanges();

            string raw_importId = context.Imports.OrderByDescending(o => o.Id).FirstOrDefault().Id.ToString();
            int importId = int.Parse(raw_importId);

            foreach (Product product in products)
            {
                ImportDetail importDetail = new ImportDetail()
                {
                    ImportId = importId,
                    PriceImport = product.Price,
                    ProductId = product.Id,
                    Quantity = product.Quantity
                };

                Product productUpdate = context.Products.Find(product.Id);
                productUpdate.Quantity = productUpdate.Quantity + product.Quantity;

                context.Products.Update(productUpdate);
                context.SaveChanges();

                context.ImportDetails.Add(importDetail);
                context.SaveChanges();
            }
            MessageBox.Show("Add new import successfully!");
            Setting.products_import = new List<Product>();
            this.Close();
        }
    }
}
