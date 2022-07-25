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
    public partial class HistoryGUI : Form
    {
        private bool isViewOrder = true;
        Shop1Context context = new Shop1Context();
        public HistoryGUI()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            if (isViewOrder)
            {
                lblHeader.Text = "History Order";
                lblCustomer.Visible = true;
                txtCustomer.Visible = true;
                btnView.Text = "View history Import";
                lblId.Text = "Order Id";

                loadDataGirdView();
            }
            else
            {
                lblHeader.Text = "History Import";
                lblCustomer.Visible = false;
                txtCustomer.Visible = false;
                btnView.Text = "View history Order";
                lblId.Text = "Import Id";
                loadDataGirdView();

            }

        }

        void loadDataGirdView()
        {
            dataGridView1.Columns.Clear();
            if (isViewOrder)
            {
                dataGridView1.DataSource = context.Orders.ToList();
                dataGridView1.Columns["CustomerAddress"].Visible = false;
                dataGridView1.Columns["DeliverDate"].Visible = false;
                dataGridView1.Columns["Staff"].Visible = false;
                dataGridView1.Columns["OrderDetails"].Visible = false;

            }
            else
            {
                dataGridView1.DataSource = context.Imports.ToList();
                dataGridView1.Columns["Staff"].Visible = false;
                dataGridView1.Columns["ImportDetails"].Visible = false;
            }
            int countColums = dataGridView1.Columns.Count;
            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.Name = "View";
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(countColums, btnView);

            dateEnd.MinDate = dateStart.Value;
            dateStart.MaxDate = dateEnd.Value;
            dateEnd.MaxDate = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.isViewOrder = !this.isViewOrder;
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            if (isViewOrder)
            {
                if (txtID.Text.Length > 0)
                {
                    try
                    {
                        int id = int.Parse(txtID.Text);
                        dataGridView1.DataSource = context.Orders.Where(o => o.Id == id).ToList();
                    }
                    catch
                    {
                        dataGridView1.DataSource = context.Orders.Where(o => o.Id == 0).ToList();
                    }
                }
                else
                {
                    if (txtStaff.Text != "")
                    {
                        dataGridView1.DataSource = context.Orders.Where(o =>
                           (
                               (o.CustomerName.Contains(txtCustomer.Text) ||
                               o.CustomerAddress.Contains(txtCustomer.Text) ||
                               o.CustomerPhone.Contains(txtCustomer.Text)) &&
                               o.StaffId == int.Parse(txtStaff.Text) &&
                               o.OrderDate >= dateStart.Value &&
                               o.OrderDate <= dateEnd.Value
                           )
                        ).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = context.Orders.Where(o =>
                           (
                               (o.CustomerName.Contains(txtCustomer.Text) ||
                               o.CustomerAddress.Contains(txtCustomer.Text) ||
                               o.CustomerPhone.Contains(txtCustomer.Text)) &&
                               o.OrderDate >= dateStart.Value &&
                               o.OrderDate <= dateEnd.Value
                           )
                        ).ToList();
                    }
                }


                dataGridView1.Columns["CustomerAddress"].Visible = false;
                dataGridView1.Columns["DeliverDate"].Visible = false;
                dataGridView1.Columns["Staff"].Visible = false;
                dataGridView1.Columns["OrderDetails"].Visible = false;

            }
            else
            {

                if (txtID.Text.Length > 0)
                {
                    try
                    {
                        int id = int.Parse(txtID.Text);
                        dataGridView1.DataSource = context.Imports.Where(o => o.Id == id).ToList();
                    }
                    catch
                    {
                        dataGridView1.DataSource = context.Imports.Where(o => o.Id == 0).ToList();
                    }
                }
                else
                {
                    if (txtStaff.Text != "")
                    {
                        dataGridView1.DataSource = context.Imports.Where(o =>
                           (
                               o.StaffId == int.Parse(txtStaff.Text) &&
                               o.ImportDate >= dateStart.Value &&
                               o.ImportDate <= dateEnd.Value
                           )
                         ).ToList();
                    }
                    else
                    {
                        dataGridView1.DataSource = context.Imports.Where(o =>
                           (
                               o.ImportDate >= dateStart.Value &&
                               o.ImportDate <= dateEnd.Value
                           )
                         ).ToList();
                    }
                }

                dataGridView1.Columns["Staff"].Visible = false;
                dataGridView1.Columns["ImportDetails"].Visible = false;
            }

            int countColums = dataGridView1.Columns.Count;
            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.Name = "View";
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(countColums, btnView);
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = sender as DateTimePicker;
            dateEnd.MinDate = date.Value;
            date.MaxDate = dateEnd.Value;
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = sender as DateTimePicker;
            date.MinDate = dateStart.Value;
            dateStart.MaxDate = date.Value;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                txtCustomer.Enabled = false;
                txtStaff.Enabled = false;
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
            }
            else
            {
                txtCustomer.Enabled = true;
                txtStaff.Enabled = true;
                dateStart.Enabled = true;
                dateEnd.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["View"].Index)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                if (isViewOrder)
                {
                    ViewOrderDetailGUI form = new ViewOrderDetailGUI(id);
                    form.ShowDialog();
                }
                else
                {
                    ViewImportDetail form = new ViewImportDetail(id);
                    form.ShowDialog();
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isData = false;
            if (isViewOrder)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    List<Order> listReportOrder = new List<Order>();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        Order o = new Order();
                        o.Id = (int)dataGridView1.Rows[i].Cells["Id"].Value;
                        o.OrderDate = (DateTime)dataGridView1.Rows[i].Cells["OrderDate"].Value;
                        o.CustomerName = (string)dataGridView1.Rows[i].Cells["CustomerName"].Value;
                        o.CustomerPhone = (string)dataGridView1.Rows[i].Cells["CustomerPhone"].Value;
                        o.TotalAmount = (double)dataGridView1.Rows[i].Cells["TotalAmount"].Value;
                        o.StaffId = (int)dataGridView1.Rows[i].Cells["StaffId"].Value;
                        listReportOrder.Add(o);
                    }
                    Setting.listReportOrder = listReportOrder;
                    isData = true;
                }
                
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    List<Import> listReportImport = new List<Import>();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        Import imp = new Import();
                        imp.Id = (int)dataGridView1.Rows[i].Cells["Id"].Value;
                        imp.ImportDate = (DateTime)dataGridView1.Rows[i].Cells["ImportDate"].Value;
                        imp.StaffId = (int)dataGridView1.Rows[i].Cells["StaffId"].Value;
                        imp.TotalAmount = (double)dataGridView1.Rows[i].Cells["TotalAmount"].Value;
                        listReportImport.Add(imp);
                    }
                    Setting.listReportImport = listReportImport;
                    isData = true;
                }
                
            }
            if(isData)
            {
                ReportGUI report = new ReportGUI(isViewOrder);
                report.ShowDialog();

            } else
            {
                MessageBox.Show("No Have Data To Report!");
            }
            
        }
    }
}
