using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class History
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime Date { get; set; }
        public bool Succsesfull { get; set; }

        public virtual User LoginNavigation { get; set; }
    }
}
