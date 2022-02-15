using System;
using System.Collections.Generic;

#nullable disable

namespace Salee
{
    public partial class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        public virtual User LoginNavigation { get; set; }
    }
}
