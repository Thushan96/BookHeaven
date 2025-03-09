namespace BookHeaven2.UI
{
    partial class AdminForm
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
            btnStaff = new Button();
            btnBook = new Button();
            btnCustomer = new Button();
            btnSales = new Button();
            btnOrders = new Button();
            btnSupplier = new Button();
            btnDashboard = new Button();
            btnSignOut = new Button();
            SuspendLayout();
            // 
            // btnStaff
            // 
            btnStaff.BackColor = SystemColors.Info;
            btnStaff.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.Location = new Point(242, 108);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(181, 73);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Staff Management";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.Info;
            btnBook.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(480, 108);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(181, 73);
            btnBook.TabIndex = 1;
            btnBook.Text = "Book Management";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.Info;
            btnCustomer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(720, 108);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(181, 73);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer Management";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = SystemColors.Info;
            btnSales.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.Location = new Point(242, 209);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(181, 72);
            btnSales.TabIndex = 3;
            btnSales.Text = "Sales Transactions";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.Info;
            btnOrders.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(480, 209);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(181, 72);
            btnOrders.TabIndex = 4;
            btnOrders.Text = "Order Management";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = SystemColors.Info;
            btnSupplier.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.Location = new Point(720, 209);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(181, 72);
            btnSupplier.TabIndex = 5;
            btnSupplier.Text = "Supplier Management";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.Info;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(480, 310);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(181, 62);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = SystemColors.ScrollBar;
            btnSignOut.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignOut.Location = new Point(1034, 362);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(143, 48);
            btnSignOut.TabIndex = 7;
            btnSignOut.Text = "Signout";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOutClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 462);
            Controls.Add(btnSignOut);
            Controls.Add(btnDashboard);
            Controls.Add(btnSupplier);
            Controls.Add(btnOrders);
            Controls.Add(btnSales);
            Controls.Add(btnCustomer);
            Controls.Add(btnBook);
            Controls.Add(btnStaff);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStaff;
        private Button btnBook;
        private Button btnCustomer;
        private Button btnSales;
        private Button btnOrders;
        private Button btnSupplier;
        private Button btnDashboard;
        private Button btnSignOut;
    }
}