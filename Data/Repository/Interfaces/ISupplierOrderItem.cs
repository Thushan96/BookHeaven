using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Repository.Interfaces
{
    public interface ISupplierOrderItemRepository
    {
        Task<SupplierOrderItem> GetByIdAsync(Guid orderItemId);

        Task<IEnumerable<SupplierOrderItem>> GetAllAsync();

        Task<IEnumerable<SupplierOrderItem>> GetBySupplierOrderIdAsync(Guid supplierOrderId);

        Task CreateAsync(SupplierOrderItem supplierOrderItem);

        Task UpdateAsync(SupplierOrderItem supplierOrderItem);

        Task DeleteAsync(Guid orderItemId);

        Task<IEnumerable<SupplierOrderItem>> GetByBookIdAsync(Guid bookId);

        Task<IEnumerable<SupplierOrderItem>> GetByQuantityRangeAsync(int minQuantity, int maxQuantity);

        Task<IEnumerable<SupplierOrderItem>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice);
    }
}
