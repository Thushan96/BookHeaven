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
            btnToday.Visible = true;
            btnWeek.Visible = true;
            btnMonth.Visible = true;

            ClearTables();
        }


        private async void btnBestSelling_Click(object sender, EventArgs e)
        {
            HideSummaryButtons();
            ClearTables();

            var bestSellingBooks = await orderService.GetBestSellingBooksAsync();
            dgvReports.Visible = true;
            dgvReports.DataSource = bestSellingBooks;
            btnDownload.Visible = true;
        }

        private async void Inventory_Click(object sender, EventArgs e)
        {
            HideSummaryButtons();
            ClearTables();

            var inventory = await bookService.GetInventory();
            dgvReports.Visible = true;
            dgvReports.DataSource = inventory;
            btnDownload.Visible = true;

        }

        private async void btnBestcustomer_Click(object sender, EventArgs e)
        {
            HideSummaryButtons();
            ClearTables();

            var bestCustomers = await orderService.GetBestCustomersAsync();
            dgvReports.Visible = true;
            dgvReports.DataSource = bestCustomers;
            btnDownload.Visible = true;

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
            btnDownload.Visible = false;
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
            btnDownload.Visible = true;
        }

        private void GenerateReport()
        {
            // Get the Downloads folder path
            var downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            var reportPath = System.IO.Path.Combine(downloadsFolder, "Report.pdf");

            // Access the rows from the DataGridView
            var rows = dgvReports.Rows;

            var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);

            using (var stream = new System.IO.FileStream(reportPath, System.IO.FileMode.Create))
            {
                var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, stream);

                document.Open();

                document.Add(new iTextSharp.text.Paragraph("Sales Report"));
                document.Add(new iTextSharp.text.Paragraph($"Generated on: {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}"));

                var table = new iTextSharp.text.pdf.PdfPTable(dgvReports.ColumnCount)
                {
                    WidthPercentage = 100
                };

                foreach (DataGridViewColumn column in dgvReports.Columns)
                {
                    table.AddCell(new iTextSharp.text.Phrase(column.HeaderText));
                }

                foreach (DataGridViewRow row in rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? string.Empty);
                    }
                }

                document.Add(table);

                document.Close();
            }

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(reportPath)
            {
                UseShellExecute = true
            });
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            GenerateReport();

        }
    }
}
