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
    public partial class ControlGUI : Form
    {
        public ControlGUI()
        {
            InitializeComponent();
            orderPage();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profilePage();
        }

        void profilePage()
        {
            ProfileGUI form = new ProfileGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            productPage();
        }

        void productPage()
        {
            ProductManageGUI form = new ProductManageGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            orderPage();
        }

        void orderPage()
        {
            OrderGUI form = new OrderGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            importPage();
        }

        void importPage()
        {
            ImportGUI form = new ImportGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historyPage();
        }

        void historyPage()
        {
            HistoryGUI form = new HistoryGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }
    }
}
