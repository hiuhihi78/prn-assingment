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
    public partial class ReportGUI : Form
    {
        Shop1Context context;
        public ReportGUI(bool isViewOrder, DateTime from, DateTime to)
        {
            InitializeComponent();
            context = new Shop1Context();
            label7.Text = from.ToString("dd/MM/yyyy hh:mm:ss");
            label9.Text = to.ToString("dd/MM/yyyy hh:mm:ss");
            if (isViewOrder)
            {
                List<Order> listOrder = Setting.listReportOrder;
                List<OrderDetail> listOrderDetails = GetListOrderDetails(listOrder);
                long sumOrders = SumOrders(listOrder);
                var products = listOrderDetails.GroupBy(o => o.ProductId).Select(p => new { Key = p.Key, Quantity = p.Sum(p => p.Quantity)}).ToList();
                int width = 20;
                int height = 20;
                for (int i = 0; i < products.Count; i++)
                {
                    Label name = new Label();
                    name.Text = (i + 1) + ". "+context.Products.Find(products[i].Key).Name;
                    Label quantity = new Label();
                    quantity.Text = products[i].Quantity.ToString();
                    name.Location = new Point(width, width*i);
                    quantity.Location = new Point(name.Width+name.Location.X+20, name.Location.Y);
                    name.Font = new Font("Segoe UI", 10);
                    quantity.Font = new Font("Segoe UI", 10);
                    panel1.Controls.Add(name);
                    panel1.Controls.Add(quantity);
                    
                }
                label3.Text = sumOrders.ToString() + " VND";

            } else
            {
                label1.Text = "Report List Import";
                List<Import> listImport = Setting.listReportImport;
                long sumImport = SumImports(listImport);
                List<ImportDetail> listImportDetails = GetListImportDetails(listImport);
                var products = listImportDetails.GroupBy(o => o.ProductId).Select(p => new { Key = p.Key, Quantity = p.Sum(p => p.Quantity) }).ToList();
                int width = 20;
                int height = 20;
                for (int i = 0; i < products.Count; i++)
                {
                    Label name = new Label();
                    name.Text = (i+1)+". "+context.Products.Find(products[i].Key).Name;
                    Label quantity = new Label();
                    quantity.Text = products[i].Quantity.ToString();
                    name.Location = new Point(width, width * i);
                    quantity.Location = new Point(name.Width + name.Location.X + 20, name.Location.Y);
                    name.Font = new Font("Segoe UI", 10);
                    quantity.Font = new Font("Segoe UI", 10);
                    panel1.Controls.Add(name);
                    panel1.Controls.Add(quantity);
                    
                }
                label3.Text = sumImport.ToString() + " VND";
            }
        }

        private long SumImports(List<Import> listImport)
        {
            long total = 0;
            foreach (var item in listImport)
            {
                total += (long)item.TotalAmount;
            }
            return total;
        }

        private List<ImportDetail> GetListImportDetails(List<Import> listImport)
        {
            List<ImportDetail> listOrderDetails = new List<ImportDetail>();
            foreach (Import item in listImport)
            {
                listOrderDetails.AddRange(context.ImportDetails.Where(o => o.ImportId == item.Id).ToList());
            }

            return listOrderDetails;
        }

        private long SumOrders(List<Order> listOrder)
        {
            long total = 0;
            foreach (var item in listOrder)
            {
                total += (long)item.TotalAmount;
            }
            return total;
        }

        private List<OrderDetail> GetListOrderDetails(List<Order> listOrder)
        {
            List<OrderDetail> listOrderDetails = new List<OrderDetail>();
            foreach (Order item in listOrder)
            {
                listOrderDetails.AddRange(context.OrderDetails.Where(o => o.OrderId == item.Id).ToList());
            }

            return listOrderDetails;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
