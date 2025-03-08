using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHeaven2.Data.Dto;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Services
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await bookRepository.GetAllBooksAsync();
        }

        public async Task<Book?> GetBookById(Guid id)
        {
            return await bookRepository.GetBookByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> SearchBooks(string keyword)
        {
            return await bookRepository.SearchBooksAsync(keyword);
        }

        public async Task AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            await bookRepository.AddBookAsync(book);
        }

        public async Task<int?> UpdateBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

           return await bookRepository.UpdateBookAsync(book);
        }

        public async Task DeleteBook(Guid id)
        {
            await bookRepository.DeleteBookAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooksBySupplier(Guid supplierId)
        {
            return await bookRepository.GetBooksBySupplierAsync(supplierId);
        }

        public async Task<IEnumerable<BookInventory>> GetInventory()
        {
            return await bookRepository.GetInventoryAsync();
        }
    }
}
