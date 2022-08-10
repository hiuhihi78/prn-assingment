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
    public partial class ViewImportDetail : Form
    {
        private int id;
        Shop1Context context = new Shop1Context();
        public ViewImportDetail(int id)
        {
            InitializeComponent();
            this.id = id;
            loadData();
        }

        void loadData()
        {
            Import import = context.Imports.Include(i => i.Staff).Where(c => c.Id == id).FirstOrDefault();
            lblId.Text = import.Id.ToString();
            lblDate.Text = import.ImportDate.ToString();
            lblStaff.Text = "(" + import.Staff.Id.ToString() + ") " + import.Staff.Fullname;
            lblTotal.Text = import.TotalAmount.ToString();

            dataGridView1.DataSource = context.ImportDetails.Include(c => c.Product).Where(s => s.ImportId == id).
                Select(p => new
                {
                    ProductName = p.Product.Name,
                    Price = p.Product.Price,
                    Quantity = p.Quantity
                })
                .ToList();
          
        }
    }
}
