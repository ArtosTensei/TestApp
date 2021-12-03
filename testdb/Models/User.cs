using System;
using System.Collections.Generic;

#nullable disable

namespace testdb.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string UserRole { get; set; }

        public virtual Role UserRoleNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
