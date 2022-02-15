using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Basket
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int IdListPur { get; set; }

        public virtual ListSale IdListPurNavigation { get; set; }
    }
}
