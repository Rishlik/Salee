using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Sum
    {
        public Sum()
        {
            ListSales = new HashSet<ListSale>();
        }

        public int Id { get; set; }
        public int? Sum1 { get; set; }

        public virtual ICollection<ListSale> ListSales { get; set; }
    }
}
