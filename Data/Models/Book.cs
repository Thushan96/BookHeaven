using System;

namespace BookHeaven2.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // 🔹 Foreign key reference to Supplier
        public Guid? SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }

    }
}
