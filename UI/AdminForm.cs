using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            var userService = Program.ServiceProvider.GetRequiredService<UserService>();
            var staffForm = new StaffForm(userService);
            staffForm.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var bookForm = new BookForm(bookService,UserRole.Admin);
            bookForm.Show();
            this.Hide();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var customerForm = new CustomerForm(customerService,UserRole.Admin);
            customerForm.Show();
            this.Hide();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var salesForm = new SalesForm(orderService,UserRole.Admin);
            salesForm.Show();
            this.Hide();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var orderForm = new OrderManagementForm(orderService, customerService, bookService,UserRole.Admin);
            orderForm.Show();
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            var supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var supplierForm = new SupplierForm(supplierService, bookService);
            supplierForm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
            var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
            var dashboard = new AdminDashboard(bookService, customerService, orderService);
            dashboard.Show();
            this.Hide();
        }

        private void btnSignOutClick(object sender, EventArgs e)
        {
            var userService = Program.ServiceProvider.GetRequiredService<UserService>();
            var loginForm = new ULoginForm(userService);
            loginForm.Show();
            this.Hide();
        }
    }
}
