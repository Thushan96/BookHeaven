using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using BookHeaven2.UI;
using BookHeaven2.Services;
using BookHeaven2.Data;
using Microsoft.EntityFrameworkCore;
using BookHeaven2.Data.Repository.Interfaces;
using BookHeaven2.Data.Repository;

namespace BookHeaven2
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
               .AddDbContext<BookstoreDbContext>(options =>
                   options.UseMySQL("server=localhost;database=heavendb;user=root;password=1234;"))
               .AddScoped<IBookRepository, BookRepository>()
               .AddScoped<ICustomerRepository, CustomerRepository>()
               .AddScoped<IOrderRepository, OrderRepository>()
               .AddScoped<ISupplierRepository, SupplierRepository>()
               .AddScoped<IUserRepository, UserRepository>()
               .AddScoped<BookService>()
               .AddScoped<CustomerService>()
               .AddScoped<OrderService>()
               .AddScoped<SupplierService>()
               .AddScoped<UserService>()
               .BuildServiceProvider();

            ServiceProvider = serviceProvider;

            var loginForm = new ULoginForm(serviceProvider.GetRequiredService<UserService>());
            Application.Run(loginForm);
        }
    }
}
