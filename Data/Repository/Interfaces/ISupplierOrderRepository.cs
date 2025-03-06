using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Repository.Interfaces
{
    public interface ISupplierOrderRepository
    {
        Task<SupplierOrder> GetByIdAsync(Guid orderId);

        Task<IEnumerable<SupplierOrder>> GetAllAsync();

        Task<IEnumerable<SupplierOrder>> GetBySupplierIdAsync(Guid supplierId);

        Task<IEnumerable<SupplierOrder>> GetByStatusAsync(string status);

        Task CreateAsync(SupplierOrder supplierOrder);

        Task UpdateAsync(SupplierOrder supplierOrder);

        Task DeleteAsync(Guid orderId);

        Task<IEnumerable<SupplierOrder>> GetByDeliveryDateRangeAsync(DateTime startDate, DateTime endDate);

        Task<IEnumerable<SupplierOrderItem>> GetOrderItemsByOrderIdAsync(Guid orderId);

        Task CreateOrderItemAsync(SupplierOrderItem orderItem);

        Task UpdateOrderItemAsync(SupplierOrderItem orderItem);

        Task DeleteOrderItemAsync(Guid orderItemId);

        Task<IEnumerable<SupplierOrder>> GetByOrderDateRangeAsync(DateTime startDate, DateTime endDate);
    }
}
