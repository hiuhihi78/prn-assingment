using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Product
    {
        public Product()
        {
            ImportDetails = new HashSet<ImportDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public string Country { get; set; }
        
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
