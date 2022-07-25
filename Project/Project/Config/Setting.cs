using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Config
{
    class Setting
    {
        public static string UserName = "";
        public static int staffId = 0;
        public static List<Product> products = new List<Product>();
        public static List<Product> products_import = new List<Product>();

        public static List<Order> listReportOrder = new List<Order>();
        public static List<Import> listReportImport = new List<Import>();
    }
}
