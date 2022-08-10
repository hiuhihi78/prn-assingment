using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class ImportDetail
    {
        public int Quantity { get; set; }
        public double PriceImport { get; set; }
        public int ImportId { get; set; }
        public int ProductId { get; set; }

        public virtual Import Import { get; set; }
        public virtual Product Product { get; set; }
    }
}
