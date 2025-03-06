using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Data.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly BookstoreDbContext _context;

        public SupplierRepository(BookstoreDbContext context)
        {
            _context = context;
        }

        public async Task<Supplier?> GetByIdAsync(Guid supplierId)
        {
            return await _context.Suppliers.Include(s => s.Books).FirstOrDefaultAsync(s => s.Id == supplierId);
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.Include(s => s.Books).ToListAsync();
        }

        public async Task CreateAsync(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid supplierId)
        {
            var supplier = await _context.Suppliers.FindAsync(supplierId);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<SupplierOrder>> GetOrdersBySupplierIdAsync(Guid supplierId)
        {
            return await _context.SupplierOrders
                .Where(o => o.SupplierId == supplierId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Supplier>> GetByNameAsync(string name)
        {
            return await _context.Suppliers
                .Where(s => s.Name.Contains(name))
                .ToListAsync();
        }

        public async Task<IEnumerable<Supplier>> GetByContactInfoAsync(string contactInfo)
        {
            return await _context.Suppliers
                .Where(s => s.ContactInfo.Contains(contactInfo))
                .ToListAsync();
        }

        public async Task<IEnumerable<SupplierOrder>> GetOrdersByStatusAsync(Guid supplierId, string status)
        {
            return await _context.SupplierOrders
                .Where(o => o.SupplierId == supplierId && o.Status == status)
                .ToListAsync();
        }
    }
}
