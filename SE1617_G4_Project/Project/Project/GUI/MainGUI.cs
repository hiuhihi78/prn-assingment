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
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();

            startPage();
            
        }

     

        void startPage()
        {
            StartGUI form = new StartGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        void controlPage()
        {
            ControlGUI form = new ControlGUI();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text.StartsWith("Login"))
            {
                LoginGUI form = new LoginGUI();
                form.ShowDialog();
            }
            else
            {
                Setting.UserName = "";
                MessageBox.Show("You are logout!");
            }
        }

        private void MainGUI_Activated(object sender, EventArgs e)
        {
            if (Setting.UserName == "")
            {
                loginToolStripMenuItem.Text = $"Login";
                startPage();
            }
            else
            {
                controlPage();
                loginToolStripMenuItem.Text = $"Logout ({Setting.UserName})";
            }
        }
    }
}
