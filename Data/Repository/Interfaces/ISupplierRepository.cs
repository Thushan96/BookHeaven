using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Repository.Interfaces
{
    public interface ISupplierRepository
    {
        Task<Supplier?> GetByIdAsync(Guid supplierId);

        Task<IEnumerable<Supplier>> GetAllAsync();

        Task CreateAsync(Supplier supplier);

        Task UpdateAsync(Supplier supplier);

        Task DeleteAsync(Guid supplierId);

        Task<IEnumerable<SupplierOrder>> GetOrdersBySupplierIdAsync(Guid supplierId);

        Task<IEnumerable<Supplier>> GetByNameAsync(string name);

        Task<IEnumerable<Supplier>> GetByContactInfoAsync(string contactInfo);

        Task<IEnumerable<SupplierOrder>> GetOrdersByStatusAsync(Guid supplierId, string status);

    }
}
