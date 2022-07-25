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

    public partial class ManageAccountGUI : Form
    {
        Shop1Context context = new Shop1Context();
        public ManageAccountGUI()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            List<Role> roles = new List<Role>()
            {
            (new Role(0, "All role")),
            (new Role(1, "Staff")),
            (new Role(2, "Manager"))
            };
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "Id";
            cboRole.SelectedValue = 0;

            dataGridView1.DataSource = context.staff.ToList();
            dataGridView1.Columns["username"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["imports"].Visible = false;
            dataGridView1.Columns["orders"].Visible = false;

            int countColums = dataGridView1.Columns.Count;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Insert(countColums, btnEdit);

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                cboRole.Enabled = false;
                txtName.Enabled = false;
            }
            else
            {
                cboRole.Enabled = true;
                txtName.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                txtId.Enabled = false;
            }
            else
            {
                txtId.Enabled = true;
            }
        }

        private void cboRole_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    dataGridView1.DataSource = context.staff.Where(p => p.Id == id).ToList();
                }
                catch
                {
                    dataGridView1.DataSource = context.staff.Where(p => p.Id == 0).ToList();
                }
            }
            else
            {
                string name = txtName.Text;
                int role = (int)cboRole.SelectedValue;
                if (role == 0)
                {
                    dataGridView1.DataSource = context.staff.Where(s => s.Fullname.Contains(name)).ToList();
                }
                else
                {
                    bool isManager = role == 2;
                    dataGridView1.DataSource = context.staff.Where(s => s.Fullname.Contains(name) && s.IsManager == isManager).ToList();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool isAddNewAccount = true;
            AddEditAccountGUI form = new AddEditAccountGUI(isAddNewAccount, 0);
            form.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                AddEditAccountGUI form = new AddEditAccountGUI(false, id);
                form.ShowDialog();
            }

        }

    }
}
