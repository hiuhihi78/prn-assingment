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
    public partial class ProfileGUI : Form
    {
        Shop1Context context = new Shop1Context();
        public ProfileGUI()
        {
            InitializeComponent();
            staff staff = context.staff.Find(Setting.staffId);
            
            
                rboActive.Enabled = false;
                rboDeactive.Enabled = false;
                rboStaff.Enabled = false;
                rboManager.Enabled = false;
            loadData();
        }

        void loadData()
        {
            staff staff = context.staff.Find(Setting.staffId);
            txtName.Text = staff.Fullname;
            txtPhone.Text = staff.Phone;
            txtAddress.Text = staff.Address;
            rboStaff.Checked = !staff.IsManager;
            rboDeactive.Checked = !staff.Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            staff staff = context.staff.Find(Setting.staffId);
            staff.Fullname = txtName.Text;
            staff.Address = txtAddress.Text;
            staff.Phone = txtPhone.Text;
            staff.IsManager = rboManager.Checked;
            staff.Status = rboActive.Checked;

            context.staff.Update(staff);
            context.SaveChanges();
            MessageBox.Show("Update user profile successfully!");
            
        }
    }
}
