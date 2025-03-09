using System;
using System.Linq;
using System.Windows.Forms;
using BookHeaven2.Services;
using BookHeaven2.Data.Models;

namespace BookHeaven2.UI
{
    public partial class StaffForm : Form
    {
        private readonly UserService userService;

        public StaffForm(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }


        private Label label2;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdate;
        private TextBox txtId;
        private Label lblUserName;
        private Label lblRole;
        private Button btnAddCustomer;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewButtonColumn colDelete;
        private ComboBox cmbRole;
        private Label lblPassword;
        private TextBox txtPassord;
        private Button btnBack;
    }
}