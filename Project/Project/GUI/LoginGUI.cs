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
    public partial class LoginGUI : Form
    {
        Shop1Context context = new Shop1Context();
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            staff staff = context.staff.Where(s => s.Username == username && s.Password == password).FirstOrDefault();

            if(staff != null)
            {
                if(staff.Status == false)
                {
                    MessageBox.Show("Your account has been looked!");
                    return;
                }

                Setting.UserName = staff.IsManager ? "Manager" : "Staff";
                Setting.staffId = staff.Id;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Faild!");
            }
            
            
        }
    }
}
