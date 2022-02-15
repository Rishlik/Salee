using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class User
    {
        public User()
        {
            Histories = new HashSet<History>();
            staff = new HashSet<Staff>();
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public int IdPrivelege { get; set; }

        public virtual Privilege IdPrivelegeNavigation { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
