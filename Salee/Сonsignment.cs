using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Сonsignment
    {
        public Сonsignment()
        {
            ComposCongsigns = new HashSet<ComposCongsign>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }

        public virtual ICollection<ComposCongsign> ComposCongsigns { get; set; }
    }
}
