using BookHeaven2.Services;
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
    public partial class AdminDashboard : Form
    {
        private readonly BookService bookService;
        private readonly CustomerService customerService;
        private readonly OrderService orderService;

        public AdminDashboard(BookService bookService, CustomerService customerService, OrderService orderService)
        {
            InitializeComponent();
            this.bookService = bookService;
            this.customerService = customerService;
            this.orderService = orderService;
        }

        private async void btnToday_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow.Date;
            await LoadOrdersIntoGrid(today, today);
        }

        private async void btnWeek_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow.Date;
            DateTime startOfWeek = today.AddDays(-((int)today.DayOfWeek)); // Start of the week (Sunday)
            await LoadOrdersIntoGrid(startOfWeek, today);
        }

        private async void btnMonth_Click(object sender, EventArgs e)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);
            DateTime today = DateTime.UtcNow.Date;
            await LoadOrdersIntoGrid(firstDayOfMonth, today);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // Show Today, Week, Month buttons
            btnToday.Visible = true;
            btnWeek.Visible = true;
            btnMonth.Visible = true;

            // Hide any table from previous selections
            ClearTables();
        }


        private async void btnBestSelling_Click(object sender, EventArgs e)
        {
            HideSummaryButtons();
            ClearTables();

            var bestSellingBooks = await orderService.GetBestSellingBooksAsync();
            dgvReports.Visible = true;
            dgvReports.DataSource = bestSellingBooks;

        }

        private async void Inventory_Click(object sender, EventArgs e)
        {
            HideSummaryButtons();
            ClearTables();

            var inventory = await bookService.GetInventory();
            dgvReports.Visible = true;
            dgvReports.DataSource = inventory;

        }

        private async void btnBestcustomer_Click(object sender, EventArgs e)
        {
            HideSummaryButtons();
            ClearTables();

            var bestCustomers = await orderService.GetBestCustomersAsync();
            dgvReports.Visible = true;
            dgvReports.DataSource = bestCustomers;

        }

        private void HideSummaryButtons()
        {
            btnToday.Visible = false;
            btnWeek.Visible = false;
            btnMonth.Visible = false;
        }

        private void ClearTables()
        {
            dgvReports.Visible = false;
            dgvReports.DataSource = null;
        }

        private async Task LoadOrdersIntoGrid(DateTime startDate, DateTime endDate)
        {
            dgvReports.Visible = true;
            var orders = await orderService.GetOrdersByDateRangeAsync(startDate, endDate);

            dgvReports.DataSource = orders.Select(o => new
            {
                OrderID = o.Id,
                Date = o.OrderDate.ToString("yyyy-MM-dd"),
                TotalAmount = o.Total
            }).ToList();
        }
    }
}
