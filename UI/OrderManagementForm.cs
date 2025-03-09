using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using BookHeaven2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookHeaven2.UI
{
    public partial class OrderManagementForm : Form
    {
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        private readonly BookService _bookService;
        private Order _currentOrder;
        private List<OrderItem> _orderItems = new List<OrderItem>();
        private readonly UserRole role;


        public OrderManagementForm(OrderService orderService, CustomerService customerService, BookService bookService, UserRole role)
        {
            InitializeComponent();
            _orderService = orderService;
            _customerService = customerService;
            _bookService = bookService;
            _currentOrder = new Order
            {
                Id = Guid.NewGuid(),
                OrderDate = DateTime.UtcNow,
                Items = new List<OrderItem>(),
                Discount = 0
            };
            InitializeOrder();
            this.role = role;
        }

        private void LoadOrderStatus()
        {
            string[] statuses = { "Pending", "Completed" };
            cmbStatus.Items.AddRange(statuses);
            cmbStatus.SelectedItem = "Completed";
            _currentOrder.Status = cmbStatus.SelectedItem.ToString();
        }

        private async void InitializeOrder()
        {
            _currentOrder = new Order
            {
                Id = Guid.NewGuid(),
                OrderDate = DateTime.UtcNow,
                Items = new List<OrderItem>(),
                Discount = 0
            };


            txtOrderId.Text = _currentOrder.Id.ToString();
            txtDate.Text = _currentOrder.OrderDate.ToString("MM/dd/yyyy");
            txtQty.Text = "";
            LoadOrderStatus();

            await LoadCustomers();
            await LoadBooks();
        }

        private async Task LoadCustomers()
        {
            var customers = await _customerService.GetAllCustomers();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";



        }

        private async Task LoadBooks()
        {
            var books = await _bookService.GetAllBooks();
            cmBook.DataSource = books;
            cmBook.DisplayMember = "Title";
            cmBook.ValueMember = "Id";


        }

        //private  void OrderForm_Load(object sender, EventArgs e)
        //{
        //    var orders = await _orderService.GetAllOrdersAsync();
        //    dataGridViewOrders.Rows.Clear();
        //    foreach (var order in orders)
        //    {
        //        dataGridViewOrders.Rows.Add(
        //            order.Id,
        //            order.Name,
        //            customer.Email,
        //            customer.PhoneNumber
        //        );
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private async void btnAddClick(object sender, EventArgs e)
        {
            if (cmBook.SelectedValue is Guid bookId && int.TryParse(txtQty.Text, out int quantity))
            {
                txtQty.Text = "";
                var book = await _bookService.GetBookById(bookId);
                if (book == null)
                {
                    MessageBox.Show("Book is not available.");
                    return;
                }
                if (book.Quantity < quantity)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }

                // Check if book already exists in order
                var existingItem = _orderItems.FirstOrDefault(i => i.BookId == book.Id);

                if (existingItem != null)
                {
                    if (book.Quantity >= existingItem.Quantity + quantity)
                    {
                        existingItem.Quantity += quantity;
                        book.Quantity -= quantity;
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available.");
                        return;
                    }
                }
                else
                {
                    var orderItem = new OrderItem
                    {
                        OrderId = _currentOrder.Id,
                        BookId = book.Id,
                        Quantity = quantity,
                        Book = book
                    };

                    _orderItems.Add(orderItem);
                    _currentOrder.Items = new List<OrderItem>(_orderItems); // Sync with order items

                    book.Quantity -= quantity;
                }

                await _bookService.UpdateBook(book);
                UpdateOrderTable();
                await LoadBooks();
            }
        }



        private void UpdateOrderTable()
        {
            dataGridViewOrders.Rows.Clear();
            foreach (var item in _orderItems)
            {
                dataGridViewOrders.Rows.Add(item.Book.Id, item.Book.Title, item.Book.Price, item.Quantity, item.Book.Price * item.Quantity);
            }

            decimal total = _orderItems.Sum(i => i.Quantity * i.Book.Price);
            txtGrossTotal.Text = total.ToString();
            txtNetTotal.Text = (total - _currentOrder.Discount).ToString();
        }




        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    var selectedRow = dataGridViewCustomers.Rows[e.RowIndex];

            //    if (e.ColumnIndex == dataGridViewCustomers.Columns["colDelete"].Index)
            //    {
            //        var id = Guid.Parse(selectedRow.Cells["colId"].Value.ToString());
            //        DeleteCustomer(id);
            //    }
            //    else
            //    {
            //        txtId.Text = selectedRow.Cells["colId"].Value.ToString();
            //        txtName.Text = selectedRow.Cells["colName"].Value.ToString();
            //        txtEmail.Text = selectedRow.Cells["colEmail"].Value.ToString();
            //        txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
            //    }
            //}

        }

        private async void dataGridViewOrdersClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewOrders.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridViewOrders.Columns["colDelete"].Index)
                {
                    var id = Guid.Parse(selectedRow.Cells["colId"].Value.ToString());
                    int quantityToRestore = int.Parse(selectedRow.Cells["colQuantity"].Value.ToString());
                    await RemoveOrderItem(id, quantityToRestore);
                    txtQty.Text = "";
                }
            }
        }

        private void cmbCustomerIndexChange(object sender, EventArgs e)
        {

            if (cmbCustomer.SelectedItem is Customer selectedCustomer)
            {
                txtCustId.Text = selectedCustomer.Id.ToString();
                txtEmail.Text = selectedCustomer.Email;
                txtContact.Text = selectedCustomer.PhoneNumber;
            }
        }

        private void cmBookIndexChanged(object sender, EventArgs e)
        {

            if (cmBook.SelectedItem is Book selectedBook)
            {
                txtIBookId.Text = selectedBook.Id.ToString();
                txtBookName.Text = selectedBook.Title;
                txtUnitPrice.Text = selectedBook.Price.ToString("F2");
                txtAvailable.Text = selectedBook.Quantity.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private async void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (_orderItems.Count == 0)
            {
                MessageBox.Show("Please add items before placing an order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentOrder.CustomerId = (Guid)cmbCustomer.SelectedValue;
            _currentOrder.Total = _orderItems.Sum(i => i.Quantity * i.Book.Price) - _currentOrder.Discount;

            if (_currentOrder.Total < 0)
            {
                MessageBox.Show("Invalid discount. Net total cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await _orderService.PlaceOrderAsync(_currentOrder);
                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReceiptGenerator.GenerateReceipt(_currentOrder);
                _orderItems.Clear();
                InitializeOrder();
                ClearTextFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to place order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextFields()
        {
            txtOrderId.Text = "";
            txtDate.Text = "";
            txtCustId.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtIBookId.Text = "";
            txtBookName.Text = "";
            txtUnitPrice.Text = "";
            txtAvailable.Text = "";
            txtQty.Text = "";
            txtGrossTotal.Text = "";
            txtNetTotal.Text = "";
            txtDiscount.Text = "";
            dataGridViewOrders.Rows.Clear();
            _orderItems = new List<OrderItem>();
        }



        private void txtNetTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private async void txtDiscountKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (txtDiscount.Text == null || txtDiscount.Text == "")
                {
                    MessageBox.Show("Discount value can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await ApplyDiscount();
                txtDiscount.Text = "";
            }
        }

        private async Task ApplyDiscount()
        {
            if (decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                if (discount < 0)
                {
                    MessageBox.Show("Discount cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtGrossTotal.Text, out decimal grossTotal))
                {
                    MessageBox.Show("Invalid gross total value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal netTotal = grossTotal - discount;
                if (netTotal < 0)
                {
                    MessageBox.Show("Discount cannot be greater than the total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtNetTotal.Text = netTotal.ToString("0.00");
                _currentOrder.Discount += discount;
            }
            else
            {
                MessageBox.Show("Invalid discount value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task RemoveOrderItem(Guid bookId, int quantityToRestore)
        {
            var orderItem = _orderItems.FirstOrDefault(i => i.BookId == bookId);
            if (orderItem != null)
            {
                _orderItems.Remove(orderItem);
                _currentOrder.Items = new List<OrderItem>(_orderItems);

                var book = await _bookService.GetBookById(bookId);
                if (book != null)
                {
                    book.Quantity += quantityToRestore;
                    await _bookService.UpdateBook(book);
                }

                UpdateOrderTable();
                await LoadBooks();
            }
            else
            {
                MessageBox.Show("Book not found in the order.");
            }
        }

        private void LoadOrderItems()
        {
            dataGridViewOrders.Rows.Clear(); // Clear existing rows

            foreach (var item in _currentOrder.Items)
            {
                dataGridViewOrders.Rows.Add(
                    item.BookId,
                    item.Book.Title,
                    item.Book.Price,
                    item.Quantity,
                    item.Book.Price * item.Quantity
                );
            }

            // Update total values
            txtGrossTotal.Text = _currentOrder.Items.Sum(i => i.Book.Price * i.Quantity).ToString("0.00");
            txtNetTotal.Text = (_currentOrder.Items.Sum(i => i.Book.Price * i.Quantity) - _currentOrder.Discount).ToString("0.00");
        }


        private async Task DeleteOrder(Guid id)
        {
            await _orderService.DeleteOrderAsync(id);
            MessageBox.Show("Order deleted successfully.");
            InitializeOrder();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbStatusIndexChange(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem != null)
            {
                _currentOrder.Status = cmbStatus.SelectedItem.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            var clerkForm = new ClerkForm();
            if (role == UserRole.Admin)
            {
                adminForm.Show();
            }
            else
            {
                clerkForm.Show();
            }
            this.Hide();
        }
    }
}