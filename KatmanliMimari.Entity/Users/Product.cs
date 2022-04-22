using System;
using System.Collections.Generic;

namespace KatmanliMimari.Entity.Users
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
