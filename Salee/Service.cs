using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Service
    {
        public Service()
        {
            Sales = new HashSet<Sale>();
        }

        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public int IdCategori { get; set; }

        public virtual Category IdCategoriNavigation { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
