using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Import
    {
        public Import()
        {
            ImportDetails = new HashSet<ImportDetail>();
        }

        public int Id { get; set; }
        public DateTime ImportDate { get; set; }
        public int StaffId { get; set; }
        public double? TotalAmount { get; set; }

        public virtual staff Staff { get; set; }
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
