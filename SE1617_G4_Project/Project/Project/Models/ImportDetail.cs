using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable

namespace Project.Models
{
    public partial class ImportDetail
    {
        public int ImportId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double PriceImport { get; set; }
        
        public virtual Import Import { get; set; }
        public virtual Product Product { get; set; }
    }
}
