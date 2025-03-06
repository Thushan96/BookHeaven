﻿using Microsoft.EntityFrameworkCore;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookstoreDbContext _context;

        public OrderRepository(BookstoreDbContext context)
        {
            _context = context;
        }

        public async Task<Order?> GetByIdAsync(Guid orderId)
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }

        public async Task<IEnumerable<Order?>> GetByCustomerIdAsync(Guid customerId)
        {
            return await _context.Orders
                .Where(o => o.CustomerId == customerId)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task CreateAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<int?> UpdateAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            var existingOrder = await _context.Orders.FindAsync(order.Id);
            if (existingOrder == null)
            {
                return null;
            }

            _context.Entry(existingOrder).CurrentValues.SetValues(order);
            return await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetByStatusAsync(string status)
        {
            return await _context.Orders
                .Where(o => o.Status == status)
                .Include(o => o.Customer)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Book)
                .ToListAsync();
        }

        public async Task<Order> PlaceOrderAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                order.OrderDate = DateTime.UtcNow;

                order.Total = order.Items.Sum(i => i.Quantity * i.Book.Price);

                order.Total -= order.Discount;

                await _context.Orders.AddAsync(order);

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return order;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

    }
}
