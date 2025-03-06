using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BookstoreDbContext _context;

        public CustomerRepository(BookstoreDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers.Include(c => c.Orders).ToListAsync();
        }

        public async Task<Customer?> GetCustomerByIdAsync(Guid id)
        {
            return await _context.Customers.Include(c => c.Orders).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Customer>> SearchCustomersAsync(string keyword)
        {
            return await _context.Customers
                .Where(c => c.Name.Contains(keyword) || c.Email.Contains(keyword))
                .Include(c => c.Orders)
                .ToListAsync();
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<int?> UpdateCustomerAsync(Customer customer)
        {

            var existingCustomer=await _context.Customers.FindAsync(customer.Id);
            if (existingCustomer == null) {
                return null;
            }

            _context.Entry(existingCustomer).CurrentValues.SetValues(customer);
            return await _context.SaveChangesAsync();
      
        }

        public async Task DeleteCustomerAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
