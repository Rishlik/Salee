using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class ListSale
    {
        public ListSale()
        {
            Baskets = new HashSet<Basket>();
        }

        public int Id { get; set; }
        public int IdSale { get; set; }
        public int Identific { get; set; }

        public virtual Sale IdSaleNavigation { get; set; }
        public virtual Sum Identific1 { get; set; }
        public virtual Purchase IdentificNavigation { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
    }
}
