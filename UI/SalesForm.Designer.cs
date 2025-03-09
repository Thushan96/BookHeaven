using System;
using System.Linq;
using System.Windows.Forms;
using BookHeaven2.Services;
using BookHeaven2.Data.Models;

namespace BookHeaven2.UI
{
    public partial class SalesForm : Form
    {
        private readonly OrderService orderService;
        private readonly UserRole role;

        public SalesForm(OrderService orderService, UserRole role)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.role = role;
        }

        private Label label2;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblTotal;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdateBooks;
        private TextBox txtId;
        private Label lblDate;
        private DataGridView dataGridViewItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colDiscount;
        private DataGridViewTextBoxColumn colStatus;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button btnBack;
    }
}