using System;
using System.Linq;
using System.Windows.Forms;
using BookHeaven2.Services;
using BookHeaven2.Data.Models;

namespace BookHeaven2.UI
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierService supplierService;
        private readonly BookService bookService;

        public SupplierForm(SupplierService supplierService, BookService bookService)
        {
            InitializeComponent();
            this.supplierService = supplierService;
            this.bookService = bookService;
        }

        private Label label2;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblConatct;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdateBooks;
        private TextBox txtId;
        private Label lblName;
        private Button btnAddBooks;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Label lblBooks;
        private ComboBox cmbBooks;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewButtonColumn colBooks;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}