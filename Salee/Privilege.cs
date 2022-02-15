using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Privilege
    {
        public Privilege()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Privilege1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
