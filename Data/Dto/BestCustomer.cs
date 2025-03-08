using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHeaven2.Data.Dto
{
    public class BestCustomer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public decimal TotalSpent { get; set; }
    }
}
