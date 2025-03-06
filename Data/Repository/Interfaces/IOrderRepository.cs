using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(Guid orderId);

        Task<IEnumerable<Order?>> GetByCustomerIdAsync(Guid customerId);

        Task CreateAsync(Order order);

        Task UpdateAsync(Order order);

        Task DeleteAsync(Guid orderId);

        Task<IEnumerable<Order>> GetAllAsync();

        Task<IEnumerable<Order>> GetByStatusAsync(string status);

        Task<Order> PlaceOrderAsync(Order order);
    }
}
