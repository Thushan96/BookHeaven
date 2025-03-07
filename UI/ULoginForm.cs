using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    public partial class ULoginForm : Form
    {
        private readonly UserService _userService;

        public ULoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //var user = new AppUser
            //{
            //    Id = Guid.NewGuid(),
            //    PasswordHash = password,
            //    Username = username,
            //    Role = UserRole.Admin
            //};

            //await _userService.CreateUserAsync(user);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            if (username.Length < 3 || password.Length < 3)
            {
                lblError.Text = "Username and password must be at least 3 characters long.";
                return;
            }

            var user = await _userService.ValidateUserAsync(username, password);
            if (user != null)
            {
                lblError.Text = "";
                MessageBox.Show("Login successful!");

                var userExist = await _userService.ValidateUserAsync(username, password);
                if (userExist != null)
                {
                    var bookService = Program.ServiceProvider.GetRequiredService<BookService>();
                    //var bookForm = new BookForm(bookService);
                    //bookForm.Show();

                    var customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
                    //var customerForm = new CustomerForm(customerService);
                    //customerForm.Show();

                    var orderService = Program.ServiceProvider.GetRequiredService<OrderService>();
                    var orderForm = new OrderManagementForm(orderService, customerService, bookService);
                    //orderForm.Show();

                    var supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
                    var supplierForm = new SupplierForm(supplierService, bookService);
                    //supplierForm.Show();

                    var salesForm = new SalesForm(orderService);
                    salesForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");

                }

            }
            else
            {
                lblError.Text = "Invalid email or password.";
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblwelcme2_Click(object sender, EventArgs e)
        {

        }

        private void ULoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
