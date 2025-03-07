using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtUserName;
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
            dataGridViewCustomers = new DataGridView();
            btnAddCustomer = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            label2 = new Label();
            lblUserName = new Label();
            lblRole = new Label();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            cmbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colRole, colDelete });
            dataGridViewCustomers.Location = new Point(183, 71);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(558, 421);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.CellClick += dataGridViewCustomers_CellClick;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.InactiveCaption;
            btnAddCustomer.Location = new Point(996, 349);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(75, 31);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddClick;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(993, 200);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 18);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 9;
            label1.Text = "Staff Management";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Location = new Point(1118, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdateClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(993, 123);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(993, 100);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 18;
            label2.Text = "Id";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(996, 177);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(75, 20);
            lblUserName.TabIndex = 19;
            lblUserName.Text = "Username";
            lblUserName.Click += label3_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(996, 245);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 20;
            lblRole.Text = "Role";
            lblRole.Click += labelEmail_Click;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.Width = 130;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.Width = 125;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 125;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(996, 281);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(197, 28);
            cmbRole.TabIndex = 21;
            // 
            // StaffForm
            // 
            ClientSize = new Size(1373, 566);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblUserName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(btnAddCustomer);
            Controls.Add(dataGridViewCustomers);
            Name = "StaffForm";
            Text = "Book List";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearTextBoxes()
        {
            txtId.Text = "";
            txtUserName.Text = "";
            
        }

        private async void StaffForm_Load(object sender, EventArgs e)
        {
            //var users = await userService.GetAllUsersAsync();
            //dataGridViewCustomers.Rows.Clear();
            //foreach (var user in users)
            //{
            //    dataGridViewCustomers.Rows.Add(
            //        customer.Id,
            //        customer.Name,
            //        customer.Email,
            //        customer.PhoneNumber
            //    );
            //}
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

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConatct_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddClick(object sender, EventArgs e)
        {
            //var customer = new Customer
            //{
            //    Id = Guid.NewGuid(),
            //    Name = txtUserName.Text,
            //};

            //try
            //{
            //    await customerService.AddCustomer(customer);

            //    CustomerForm_Load(sender, e);

            //    MessageBox.Show("Customer added successfully!");
            //    clearTextBoxes();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error adding Customer: {ex.Message}");
            //}
        }

        private async void btnUpdateClick(object sender, EventArgs e)
        {
            //if (txtId.Text == "")
            //{
            //    MessageBox.Show("Please select a Customer to update");
            //    return;
            //}
            //var customer = new Customer
            //{
            //    Id = Guid.Parse(txtId.Text),
            //    Name = txtUserName.Text,
            //    Email = txtEmail.Text,
            //    PhoneNumber = txtContact.Text,
            //};

            //var updated = await customerService.UpdateCustomer(customer);
            //if (updated != null && updated > 0)
            //{
            //    MessageBox.Show("Customer updated successfully");
            //    CustomerForm_Load(sender, e);
            //    clearTextBoxes();
            //}
            //else
            //{
            //    MessageBox.Show("Customer update failed");
            //}
        }


        private async void DeleteCustomer(Guid id)
        {
     

            //if (id != null)
            //{
            //    try
            //    {
            //        await customerService.DeleteCustomer(id);

            //        CustomerForm_Load(this, EventArgs.Empty);

            //        MessageBox.Show("Customer deleted successfully!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error deleting book: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Customer not found!");
            //}
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
            //        txtUserName.Text = selectedRow.Cells["colName"].Value.ToString();
            //        txtEmail.Text = selectedRow.Cells["colEmail"].Value.ToString();
            //        txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
            //    }
            //}

        }

       
    }
}
