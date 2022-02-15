using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class ComposCongsign
    {
        public int Id { get; set; }
        public int IdConsigm { get; set; }
        public int IdCompon { get; set; }
        public int IdCounterpart { get; set; }
        public int IdSotrud { get; set; }
        public int Count { get; set; }
        public int Sum { get; set; }

        public virtual Сonsignment IdConsigmNavigation { get; set; }
        public virtual Counterparty IdCounterpartNavigation { get; set; }
    }
}
