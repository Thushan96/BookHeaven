using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookHeaven2.Data
{
    public class BookstoreDbContextFactory : IDesignTimeDbContextFactory<BookstoreDbContext>
    {
        public BookstoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookstoreDbContext>();
            optionsBuilder.UseMySQL("server=localhost;database=heavendb;user=root;password=1234;");

            return new BookstoreDbContext(optionsBuilder.Options);
        }
    }
}
