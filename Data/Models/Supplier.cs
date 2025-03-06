using System;
using System.Collections.Generic;

namespace BookHeaven2.Data.Models
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();

        public virtual ICollection<SupplierOrder>? SupplierOrders { get; set; }

    }
}
