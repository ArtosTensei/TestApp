using System;
using System.Collections.Generic;

#nullable disable

namespace testdb.Models
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
