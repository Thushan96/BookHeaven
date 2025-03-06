using System;
using System.Linq;
using System.Windows.Forms;
using BookHeaven2.Services;
using BookHeaven2.Data.Models;

namespace BookHeaven2.UI
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService customerService;

        public CustomerForm(CustomerService customerService)
        {
            InitializeComponent();
            this.customerService = customerService;
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            var customers = await customerService.GetAllCustomers();
            dataGridViewCustomers.Rows.Clear(); 
            foreach (var customer in customers)
            {
                dataGridViewCustomers.Rows.Add(
                    customer.Id,
                    customer.Name,
                    customer.Email,
                    customer.PhoneNumber
                );
            }
        }

        private Label label2;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblConatct;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdate;
        private TextBox txtId;
        private Label lblName;
        private Label labelEmail;
        private Button btnAddCustomer;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewButtonColumn colDelete;
    }
}