using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeaven2.Data.Dto;
using BookHeaven2.Data.Models;

namespace BookHeaven2.Data.Repository.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();

        Task<Book?> GetBookByIdAsync(Guid id);

        Task<IEnumerable<Book>> SearchBooksAsync(string keyword);

        Task AddBookAsync(Book book);

        Task<int?> UpdateBookAsync(Book book);

        Task DeleteBookAsync(Guid id);

        Task UpdateStockAsync(Guid bookId, int newQuantity);

        Task<IEnumerable<Book>> GetBooksBySupplierAsync(Guid supplierId);

        Task<IEnumerable<BookInventory>> GetInventoryAsync();

    }
}
