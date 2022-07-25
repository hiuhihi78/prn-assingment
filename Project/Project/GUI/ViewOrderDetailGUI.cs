using Microsoft.EntityFrameworkCore;
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
    public partial class ViewOrderDetailGUI : Form
    {
        private int id;
        Shop1Context context = new Shop1Context();
        public ViewOrderDetailGUI(int id)
        {
            InitializeComponent();
            this.id = id;
            loadData();
        }

        void loadData()
        {
            Order import = context.Orders.Include(i => i.Staff).Where(c => c.Id == id).FirstOrDefault();
            lblId.Text = import.Id.ToString();
            lblDate.Text = import.OrderDate.ToString();
            lblStaff.Text = "(" + import.Staff.Id.ToString() + ") " + import.Staff.Fullname;
            lblTotal.Text = import.TotalAmount.ToString();
            lblAddress.Text = import.CustomerAddress;
            lblName.Text = import.CustomerName;
            lblPhone.Text = import.CustomerPhone;
            dataGridView1.DataSource = context.OrderDetails.Where(s => s.OrderId == id).ToList();
            dataGridView1.Columns["Order"].Visible = false;
            dataGridView1.Columns["Product"].Visible = false;
            dataGridView1.Columns["OrderId"].Visible = false;
        }













        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
