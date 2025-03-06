
namespace BookHeaven2.UI
{
    partial class OrderManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewOrders = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            lblInvoice = new Label();
            lblOrderId = new Label();
            txtOrderId = new TextBox();
            lblDate = new Label();
            txtDate = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            lblCustomer = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmBook = new ComboBox();
            lblCustId = new Label();
            txtCustId = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblConatctNo = new Label();
            txtContact = new TextBox();
            lblItemDetails = new Label();
            lblItemId = new Label();
            lblBook = new Label();
            cmbCustomer = new ComboBox();
            txtIBookId = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblAvailable = new Label();
            txtAvailable = new TextBox();
            btnAdd = new Button();
            lblGrossTotal = new Label();
            txtGrossTotal = new TextBox();
            lblNetTotal = new Label();
            txtNetTotal = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            btnPlaceOrder = new Button();
            btnCancel = new Button();
            lblQty = new Label();
            txtQty = new TextBox();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice, colQuantity, colTotal, colDelete });
            dataGridViewOrders.Location = new Point(128, 314);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(906, 268);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.CellContentClick += dataGridViewOrdersClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 130;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 130;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.Width = 130;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 130;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 125;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 130;
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoice.Location = new Point(36, 29);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(152, 28);
            lblInvoice.TabIndex = 2;
            lblInvoice.Text = "Invoice Details";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(36, 72);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(67, 20);
            lblOrderId.TabIndex = 3;
            lblOrderId.Text = "OrderId :";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(109, 69);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(248, 71);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 20);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date :";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(302, 65);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 6;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(36, 125);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(79, 20);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Customer :";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cmBook
            // 
            cmBook.FormattingEnabled = true;
            cmBook.Location = new Point(546, 72);
            cmBook.Name = "cmBook";
            cmBook.Size = new Size(132, 28);
            cmBook.TabIndex = 9;
            cmBook.SelectedIndexChanged += cmBookIndexChanged;
            // 
            // lblCustId
            // 
            lblCustId.AutoSize = true;
            lblCustId.Location = new Point(259, 120);
            lblCustId.Name = "lblCustId";
            lblCustId.Size = new Size(29, 20);
            lblCustId.TabIndex = 10;
            lblCustId.Text = "Id :";
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(294, 120);
            txtCustId.Name = "txtCustId";
            txtCustId.ReadOnly = true;
            txtCustId.Size = new Size(125, 27);
            txtCustId.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(36, 169);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(168, 27);
            txtEmail.TabIndex = 13;
            // 
            // lblConatctNo
            // 
            lblConatctNo.AutoSize = true;
            lblConatctNo.Location = new Point(36, 211);
            lblConatctNo.Name = "lblConatctNo";
            lblConatctNo.Size = new Size(91, 20);
            lblConatctNo.TabIndex = 14;
            lblConatctNo.Text = "Conatct No :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(128, 208);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(168, 27);
            txtContact.TabIndex = 15;
            // 
            // lblItemDetails
            // 
            lblItemDetails.AutoSize = true;
            lblItemDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemDetails.Location = new Point(470, 29);
            lblItemDetails.Name = "lblItemDetails";
            lblItemDetails.Size = new Size(127, 28);
            lblItemDetails.TabIndex = 16;
            lblItemDetails.Text = "Item Details";
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new Point(684, 72);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(29, 20);
            lblItemId.TabIndex = 17;
            lblItemId.Text = "Id :";
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(470, 72);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(50, 20);
            lblBook.TabIndex = 18;
            lblBook.Text = "Book :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(121, 120);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(132, 28);
            cmbCustomer.TabIndex = 19;
            cmbCustomer.SelectedIndexChanged += cmbCustomerIndexChange;
            // 
            // txtIBookId
            // 
            txtIBookId.Location = new Point(728, 71);
            txtIBookId.Name = "txtIBookId";
            txtIBookId.ReadOnly = true;
            txtIBookId.Size = new Size(109, 27);
            txtIBookId.TabIndex = 20;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(559, 113);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(278, 27);
            txtBookName.TabIndex = 21;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(470, 123);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(56, 20);
            lblBookName.TabIndex = 22;
            lblBookName.Text = "Name :";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(470, 169);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(83, 20);
            lblUnitPrice.TabIndex = 23;
            lblUnitPrice.Text = "Unit Price  :";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(559, 162);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(278, 27);
            txtUnitPrice.TabIndex = 24;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(470, 211);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(82, 20);
            lblAvailable.TabIndex = 25;
            lblAvailable.Text = "Available  :";
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(559, 208);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.Size = new Size(125, 27);
            txtAvailable.TabIndex = 26;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(728, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 32);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddClick;
            // 
            // lblGrossTotal
            // 
            lblGrossTotal.AutoSize = true;
            lblGrossTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossTotal.Location = new Point(890, 76);
            lblGrossTotal.Name = "lblGrossTotal";
            lblGrossTotal.Size = new Size(95, 20);
            lblGrossTotal.TabIndex = 28;
            lblGrossTotal.Text = "Gross Total  :";
            // 
            // txtGrossTotal
            // 
            txtGrossTotal.Location = new Point(989, 72);
            txtGrossTotal.Name = "txtGrossTotal";
            txtGrossTotal.ReadOnly = true;
            txtGrossTotal.Size = new Size(141, 27);
            txtGrossTotal.TabIndex = 29;
            // 
            // lblNetTotal
            // 
            lblNetTotal.AutoSize = true;
            lblNetTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetTotal.Location = new Point(890, 173);
            lblNetTotal.Name = "lblNetTotal";
            lblNetTotal.Size = new Size(83, 20);
            lblNetTotal.TabIndex = 30;
            lblNetTotal.Text = "Net Total  :";
            // 
            // txtNetTotal
            // 
            txtNetTotal.Location = new Point(989, 166);
            txtNetTotal.Name = "txtNetTotal";
            txtNetTotal.ReadOnly = true;
            txtNetTotal.Size = new Size(141, 27);
            txtNetTotal.TabIndex = 31;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(890, 125);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(78, 20);
            lblDiscount.TabIndex = 32;
            lblDiscount.Text = "Discount  :";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(989, 125);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(141, 27);
            txtDiscount.TabIndex = 33;
            txtDiscount.KeyDown += txtDiscountKeyDown;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = SystemColors.Info;
            btnPlaceOrder.Location = new Point(1012, 252);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(109, 37);
            btnPlaceOrder.TabIndex = 34;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(890, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 34);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(471, 256);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(76, 20);
            lblQty.TabIndex = 36;
            lblQty.Text = "Quantity  :";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(559, 256);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(125, 27);
            txtQty.TabIndex = 37;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(989, 211);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(141, 28);
            cmbStatus.TabIndex = 38;
            cmbStatus.SelectedIndexChanged += CmbStatusIndexChange;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(890, 215);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 20);
            lblStatus.TabIndex = 39;
            lblStatus.Text = "Status :";
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 594);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(txtQty);
            Controls.Add(lblQty);
            Controls.Add(btnCancel);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(txtNetTotal);
            Controls.Add(lblNetTotal);
            Controls.Add(txtGrossTotal);
            Controls.Add(lblGrossTotal);
            Controls.Add(btnAdd);
            Controls.Add(txtAvailable);
            Controls.Add(lblAvailable);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblBookName);
            Controls.Add(txtBookName);
            Controls.Add(txtIBookId);
            Controls.Add(cmbCustomer);
            Controls.Add(lblBook);
            Controls.Add(lblItemId);
            Controls.Add(lblItemDetails);
            Controls.Add(txtContact);
            Controls.Add(lblConatctNo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtCustId);
            Controls.Add(lblCustId);
            Controls.Add(cmBook);
            Controls.Add(lblCustomer);
            Controls.Add(txtDate);
            Controls.Add(lblDate);
            Controls.Add(txtOrderId);
            Controls.Add(lblOrderId);
            Controls.Add(lblInvoice);
            Controls.Add(dataGridViewOrders);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblInvoice;
        private Label lblOrderId;
        private TextBox txtOrderId;
        private Label lblDate;
        private TextBox txtDate;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label lblCustomer;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cmBook;
        private Label lblCustId;
        private TextBox txtCustId;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblConatctNo;
        private TextBox txtContact;
        private Label lblItemDetails;
        private Label lblItemId;
        private Label lblBook;
        private ComboBox cmbCustomer;
        private TextBox txtIBookId;
        private TextBox txtBookName;
        private Label lblBookName;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblAvailable;
        private TextBox txtAvailable;
        private Button btnAdd;
        private Label lblGrossTotal;
        private TextBox txtGrossTotal;
        private Label lblNetTotal;
        private TextBox txtNetTotal;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Button btnPlaceOrder;
        private Button btnCancel;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewButtonColumn colDelete;
        private DataGridView dataGridViewOrders;
        private Label lblQty;
        private TextBox txtQty;
        private ComboBox cmbStatus;
        private Label lblStatus;
    }
}