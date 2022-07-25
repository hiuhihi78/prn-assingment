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
    public partial class AddEditAccountGUI : Form
    {
        bool isAdd;
        int id;
        Shop1Context context = new Shop1Context();
        public AddEditAccountGUI(bool isAdd, int id)
        {
            InitializeComponent();
            this.isAdd = isAdd;
            this.id = id;
            loadData();
        }

        void loadData()
        {
            List<Role> roles = new List<Role>()
                    {
                    (new Role(1, "Staff")),
                    (new Role(2, "Manager"))
                    };
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "Id";
            cboRole.SelectedValue = 1;
            if (isAdd)
            {
                lblHeader.Text = "Add new account";
            }
            else
            {
                lblHeader.Text = "Edit account";

                staff staff = context.staff.Find(id);

                txtPassword.PasswordChar = '*';
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
                txtAddress.Enabled = false;
                txtPhone.Enabled = false;
                txtFullName.Enabled = false;
                cboRole.Enabled = false;

                txtPassword.Text = staff.Password;
                txtUsername.Text = staff.Username;
                txtAddress.Text = staff.Address;
                txtPhone.Text = staff.Password;
                txtFullName.Text = staff.Password;
                cboRole.SelectedValue = staff.IsManager == true ? 2 : 1;
                rboDeactivate.Checked = staff.Status == false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool allow = txtAddress.Text.Length > 0 &&
                txtFullName.Text.Length > 0 &&
                txtPassword.Text.Length > 0 &&
                txtPhone.Text.Length > 0 &&
                txtUsername.Text.Length > 0;
            if (allow)
            {
                if (isAdd == true)
                {
                    staff staff = new staff()
                    {
                        Address = txtAddress.Text,
                        Fullname = txtFullName.Text,
                        Password = txtPassword.Text,
                        Phone = txtPhone.Text,
                        Username = txtUsername.Text,
                        Status = rboActivate.Checked,
                        IsManager = (int)cboRole.SelectedValue == 2
                    };
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Alter", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        context.staff.Add(staff);
                        context.SaveChanges();
                        MessageBox.Show("Add new account successfully!", "Add new account");
                        this.Close();
                    }
                }
                else
                {
                    staff staff = context.staff.Find(id);
                    staff.Status = rboActivate.Checked;
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Alter", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        context.staff.Update(staff);
                        context.SaveChanges();
                        MessageBox.Show("Edit account successfully!", "Update account");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must fill all field in this form!");
            }
        }
    }
}
