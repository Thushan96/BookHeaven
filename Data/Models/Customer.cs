using System;
using System.Collections.Generic;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
