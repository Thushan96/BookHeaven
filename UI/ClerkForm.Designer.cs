namespace BookHeaven2.UI
{
    partial class ClerkForm
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
            btnOrders = new Button();
            btnSales = new Button();
            btnCustomer = new Button();
            btnBook = new Button();
            btnSignOut = new Button();
            lblTabs = new Label();
            SuspendLayout();
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.Info;
            btnOrders.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(121, 168);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(181, 72);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Order Management";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = SystemColors.Info;
            btnSales.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.Location = new Point(350, 168);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(181, 72);
            btnSales.TabIndex = 6;
            btnSales.Text = "Sales Transactions";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.Info;
            btnCustomer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(572, 168);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(181, 73);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customer Management";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.Info;
            btnBook.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(800, 168);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(181, 73);
            btnBook.TabIndex = 8;
            btnBook.Text = "Book Management";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = SystemColors.ScrollBar;
            btnSignOut.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignOut.Location = new Point(1016, 362);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(143, 48);
            btnSignOut.TabIndex = 9;
            btnSignOut.Text = "Signout";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblTabs
            // 
            lblTabs.AutoSize = true;
            lblTabs.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTabs.Location = new Point(562, 49);
            lblTabs.Name = "lblTabs";
            lblTabs.Size = new Size(61, 31);
            lblTabs.TabIndex = 10;
            lblTabs.Text = "Tabs";
            // 
            // ClerkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1204, 450);
            Controls.Add(lblTabs);
            Controls.Add(btnSignOut);
            Controls.Add(btnBook);
            Controls.Add(btnCustomer);
            Controls.Add(btnSales);
            Controls.Add(btnOrders);
            Name = "ClerkForm";
            Text = "ClerkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrders;
        private Button btnSales;
        private Button btnCustomer;
        private Button btnBook;
        private Button btnSignOut;
        private Label lblTabs;
    }
}