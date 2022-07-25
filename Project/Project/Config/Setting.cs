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
    }

    class Role
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }


}
