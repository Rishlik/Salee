using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Purchase
    {
        public Purchase()
        {
            ListSales = new HashSet<ListSale>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<ListSale> ListSales { get; set; }
    }
}
