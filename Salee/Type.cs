using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Type
    {
        public Type()
        {
            Components = new HashSet<Component>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Component> Components { get; set; }
    }
}
