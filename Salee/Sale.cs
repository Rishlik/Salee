using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Sale
    {
        public Sale()
        {
            ListSales = new HashSet<ListSale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public virtual Service Name1 { get; set; }
        public virtual Component NameNavigation { get; set; }
        public virtual ICollection<ListSale> ListSales { get; set; }
    }
}
