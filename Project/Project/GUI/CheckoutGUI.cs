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
    public partial class CheckoutGUI : Form
    {
        Shop1Context context = new Shop1Context();
        List<Product> products = Setting.products;
        public CheckoutGUI()
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
            NumericUpDown numericUp;
            Button button;
            Label labelPrice;
            Label labelDiscount;
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

                

                labelPrice = new Label();
                labelPrice.Text = products[i].Price.ToString();
                labelPrice.Location = new Point(numericUp.Width + numericUp.Location.X + margin_left, numericUp.Location.Y);

                labelDiscount = new Label();
                labelDiscount.Text = products[i].Discount.ToString() + "%";
                labelDiscount.Location = new Point(labelPrice.Width + labelPrice.Location.X + margin_left, labelPrice.Location.Y);

                button = new Button();
                button.Name = $"num_{products[i].Id}";
                button.Location = new Point(labelDiscount.Width + labelDiscount.Location.X , labelDiscount.Location.Y);
                button.Text = "x";
                button.Width = 27;
                button.Height = 27;
                button.Click += new EventHandler(button_Click);

                panel1.Controls.Add(label);
                panel1.Controls.Add(numericUp);
                panel1.Controls.Add(labelPrice);
                panel1.Controls.Add(labelDiscount);
                panel1.Controls.Add(button);
            }
        }

        private void numericUp_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUp = sender as NumericUpDown;

            string raw_productId = numericUp.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId);

            int maxQuantity = context.Products.Find(productId).Quantity;
            if(numericUp.Value > maxQuantity)
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

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string raw_productId = button.Name.Replace("num_", "");
            int productId = int.Parse(raw_productId);
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
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

            int IDENTITY = 1;
            var raw_orderId = context.Orders.OrderByDescending(o => o.Id).FirstOrDefault();
            int orderId = IDENTITY;

            if(raw_orderId != null)
            {
                orderId = (context.Orders.OrderByDescending(o => o.Id).FirstOrDefault() as Order).Id + 1;
            }

            Order order = new Order()
            {
                Id = orderId,
                CustomerName = txtName.Text,
                CustomerPhone = txtPhone.Text,
                CustomerAddress = txtAddress.Text,
                OrderDate =  DateTime.Now,
                StaffId = Setting.staffId,
                TotalAmount = double.Parse(lblTotal.Text),
                DeliverDate = DateTime.Now
            };

            context.Orders.Add(order);
            context.SaveChanges();
            
            

            foreach(Product product in products)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = orderId,
                    ProductId = product.Id,
                    Quantity = product.Quantity,
                    SellPrice = (product.Discount == 0) ? product.Quantity * product.Price : product.Quantity * product.Price * product.Discount / 100
                };

                Product productUpdate = context.Products.Find(product.Id);
                productUpdate.Quantity = productUpdate.Quantity - product.Quantity;
                
                context.Products.Update(productUpdate);
                context.SaveChanges();

                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
            MessageBox.Show("Add new order successfully!");
            Setting.products = new List<Product>();
            this.Close();
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
