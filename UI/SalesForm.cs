using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colDiscount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            txtDate = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            lblTotal = new Label();
            btnUpdateBooks = new Button();
            txtId = new TextBox();
            label2 = new Label();
            lblDate = new Label();
            dataGridViewItems = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colId, colDate, colTotal, colDiscount, colStatus });
            dataGridView.Location = new Point(130, 62);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(741, 264);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridViewSales_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Resizable = DataGridViewTriState.True;
            colId.Width = 140;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.Width = 140;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.Width = 140;
            // 
            // colDiscount
            // 
            colDiscount.HeaderText = "Discount";
            colDiscount.MinimumWidth = 6;
            colDiscount.Name = "colDiscount";
            colDiscount.Resizable = DataGridViewTriState.True;
            colDiscount.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Resizable = DataGridViewTriState.True;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStatus.Width = 140;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(996, 161);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(200, 27);
            txtDate.TabIndex = 3;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(996, 230);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(200, 27);
            txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 18);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 9;
            label1.Text = "Sales Transactions";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(999, 207);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            lblTotal.Click += lblConatct_Click;
            // 
            // btnUpdateBooks
            // 
            btnUpdateBooks.BackColor = SystemColors.Info;
            btnUpdateBooks.Location = new Point(1013, 424);
            btnUpdateBooks.Name = "btnUpdateBooks";
            btnUpdateBooks.Size = new Size(75, 39);
            btnUpdateBooks.TabIndex = 16;
            btnUpdateBooks.TabStop = false;
            btnUpdateBooks.Text = "Update";
            btnUpdateBooks.UseVisualStyleBackColor = false;
            btnUpdateBooks.Click += btnUpdateSales_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(996, 96);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(993, 65);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 18;
            label2.Text = "Id";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(999, 138);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 19;
            lblDate.Text = "Date";
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewItems.Location = new Point(219, 341);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(554, 199);
            dataGridViewItems.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Order Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Book Title";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Quantity";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Total";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Conatct No";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Books";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Delete";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Text = "Delete";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 140;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(1003, 341);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Completed", "" });
            cmbStatus.Location = new Point(1006, 374);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(190, 28);
            cmbStatus.TabIndex = 21;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(999, 278);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 22;
            lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(1003, 301);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(200, 27);
            txtDiscount.TabIndex = 23;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1242, 514);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 37);
            btnBack.TabIndex = 41;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SalesForm
            // 
            ClientSize = new Size(1373, 573);
            Controls.Add(btnBack);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dataGridViewItems);
            Controls.Add(lblDate);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnUpdateBooks);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtDate);
            Controls.Add(dataGridView);
            Name = "SalesForm";
            Text = "Book List";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private async void SalesForm_Load(object sender, EventArgs e)
        {
            dataGridViewItems.Visible = false;
            await Task.Delay(1000);


            var orders = await orderService.GetAllOrdersAsync();
            dataGridView.Rows.Clear();

            foreach (var order in orders)
            {
                int rowIndex = dataGridView.Rows.Add(
                    order.Id,
                    order.OrderDate,
                    order.Total,
                    order.Discount,
                    order.Status
                );
            }
        }


        //private async void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var orderId = (Guid)dataGridViewSales.Rows[e.RowIndex].Cells["colId"].Value;
        //    if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSales.Columns["colBooks"].Index)
        //    {
        //        LoadBooksForSupplier(supplierId);
        //    }
        //    if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSales.Columns["colDelete"].Index) {
        //        await DeleteSupplier(supplierId);
        //    }
        //    else{
        //        var selectedRow = dataGridViewSales.Rows[e.RowIndex];
        //        txtId.Text = selectedRow.Cells["colId"].Value.ToString();
        //        txtName.Text = selectedRow.Cells["colName"].Value.ToString();
        //        txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
        //    }
        //}

        private async void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.ColumnIndex == dataGridView.Columns["colStatus"].Index)
            {

            }
        }


        private async void LoadItemsForOrder(Guid id)
        {
            dataGridViewItems.Visible = true;

            var orderItems = await orderService.GetOrderItemsAsync(id);
            dataGridViewItems.Rows.Clear();

            foreach (var orderItem in orderItems)
            {
                var total = orderItem.Quantity * orderItem.Book.Price;
                dataGridViewItems.Rows.Add(
                    orderItem.OrderId,
                    orderItem.Book.Title,
                    orderItem.Quantity,
                    total
                );
            }
        }


        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void ClearTextBoxes()
        {

            txtId.Text = "";
            txtDate.Text = "";
            txtTotal.Text = "";
            txtDiscount.Text = "";
            dataGridViewItems.Rows.Clear();
            dataGridViewItems.Visible = false;
            cmbStatus.SelectedIndex = -1;
        }



        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void lblConatct_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadOrders()
        {
            dataGridViewItems.Visible = false;
            await Task.Delay(1000);


            var orders = await orderService.GetAllOrdersAsync();
            dataGridView.Rows.Clear();

            foreach (var order in orders)
            {
                int rowIndex = dataGridView.Rows.Add(
                    order.Id,
                    order.OrderDate,
                    order.Total,
                    order.Discount,
                    order.Status
                );
            }
        }

        private async void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView.Rows[e.RowIndex];

                if (row.Cells["colId"].Value != null &&
                    row.Cells["colDate"].Value != null &&
                    row.Cells["colTotal"].Value != null &&
                    row.Cells["colDiscount"].Value != null &&
                    row.Cells["colStatus"].Value != null)
                {
                    txtId.Text = row.Cells["colId"].Value.ToString();
                    LoadItemsForOrder(Guid.Parse(txtId.Text));


                    txtDate.Text = row.Cells["colDate"].Value.ToString();

                    txtTotal.Text = row.Cells["colTotal"].Value.ToString();

                    txtDiscount.Text = row.Cells["colDiscount"].Value.ToString();

                    cmbStatus.SelectedItem = row.Cells["colStatus"].Value.ToString();
                    cmbStatus.Tag = e.RowIndex;
                }
                else
                {
                    MessageBox.Show("One or more required fields are empty or invalid.");
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpdateSales_Click(object sender, EventArgs e)
        {
            try
            {
                var orderId = Guid.Parse(txtId.Text);
                string status = cmbStatus.SelectedItem.ToString();
                if (status == "")
                {
                    MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var order = await orderService.GetOrderByIdAsync(orderId);
                if (order != null)
                {
                    order.Status = status;

                    await orderService.UpdateOrderAsync(order);

                    MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    await LoadOrders();
                }
                else
                {
                    MessageBox.Show("Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
