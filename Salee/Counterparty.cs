using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Counterparty
    {
        public Counterparty()
        {
            ComposCongsigns = new HashSet<ComposCongsign>();
        }

        public int Id { get; set; }
        public string NameOrganization { get; set; }
        public string Adress { get; set; }
        public string Inn { get; set; }
        public string ContactPhone { get; set; }

        public virtual ICollection<ComposCongsign> ComposCongsigns { get; set; }
    }
}
