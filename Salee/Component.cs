using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Component
    {
        public Component()
        {
            Sales = new HashSet<Sale>();
        }

        public string Name { get; set; }
        public int IdType { get; set; }
        public string Description { get; set; }
        public int IdCategori { get; set; }
        public int Cost { get; set; }
        public bool Presence { get; set; }

        public virtual Category IdCategoriNavigation { get; set; }
        public virtual Type IdTypeNavigation { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
