using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookstoreDbContext _context;

        public BookRepository(BookstoreDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books.Include(b => b.Supplier).ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(Guid id)
        {
            return await _context.Books.Include(b => b.Supplier).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Book>> SearchBooksAsync(string keyword)
        {
            return await _context.Books
                .Where(b => b.Title.Contains(keyword) || b.Author.Contains(keyword) || b.Genre.Contains(keyword))
                .Include(b => b.Supplier)
                .ToListAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        public async Task<int?> UpdateBookAsync(Book book)
        {
            var existingBook = await _context.Books.FindAsync(book.Id);
            if (existingBook == null)
            {
                return null;
            }

            _context.Entry(existingBook).CurrentValues.SetValues(book);

            return await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetBooksBySupplierAsync(Guid supplierId)
        {
            return await _context.Books
                .Where(b => b.SupplierId == supplierId)
                .Include(b => b.Supplier)
                .ToListAsync();
        }

        Task IBookRepository.UpdateStockAsync(Guid bookId, int newQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
