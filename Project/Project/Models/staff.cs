using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class staff
    {
        public staff()
        {
            Imports = new HashSet<Import>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsManager { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Import> Imports { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
