using BookHeaven2.Data.Models;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            label1 = new Label();
            lblConatct = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            label2 = new Label();
            lblName = new Label();
            labelEmail = new Label();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            this.colContact = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colEmail, this.colContact, colDelete });
            dataGridViewCustomers.Location = new Point(85, 70);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(685, 453);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.CellClick += dataGridViewCustomers_CellClick;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.InactiveCaption;
            btnAddCustomer.Location = new Point(993, 409);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(75, 31);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(993, 200);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(993, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtAuthor_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(993, 345);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 27);
            txtContact.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 18);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 9;
            label1.Text = "Customer Management";
            // 
            // lblConatct
            // 
            lblConatct.AutoSize = true;
            lblConatct.Location = new Point(996, 322);
            lblConatct.Name = "lblConatct";
            lblConatct.Size = new Size(84, 20);
            lblConatct.TabIndex = 12;
            lblConatct.Text = "Contact No";
            lblConatct.Click += lblConatct_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Location = new Point(1109, 409);
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(996, 177);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            lblName.Click += label3_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(996, 245);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 20;
            labelEmail.Text = "Email";
            labelEmail.Click += labelEmail_Click;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 130;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.Width = 125;
            // 
            // colContact
            // 
            this.colContact.HeaderText = "Conatct No";
            this.colContact.MinimumWidth = 6;
            this.colContact.Name = "colContact";
            this.colContact.Width = 125;
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
            // CustomerForm
            // 
            ClientSize = new Size(1373, 566);
            Controls.Add(labelEmail);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(lblConatct);
            Controls.Add(label1);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnAddCustomer);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomerForm";
            Text = "Book List";
            Load += CustomerForm_Load;
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
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
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
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtContact.Text,
            };

            try
            {
                await customerService.AddCustomer(customer);

                CustomerForm_Load(sender, e);

                MessageBox.Show("Customer added successfully!");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Customer: {ex.Message}");
            }
        }

        private async void btnUpdateClick(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a Customer to update");
                return;
            }
            var customer = new Customer
            {
                Id = Guid.Parse(txtId.Text),
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtContact.Text,
            };

            var updated = await customerService.UpdateCustomer(customer);
            if (updated != null && updated > 0)
            {
                MessageBox.Show("Customer updated successfully");
                CustomerForm_Load(sender, e);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Customer update failed");
            }
        }


        private async void DeleteCustomer(Guid id)
        {
     

            if (id != null)
            {
                try
                {
                    await customerService.DeleteCustomer(id);

                    CustomerForm_Load(this, EventArgs.Empty);

                    MessageBox.Show("Customer deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Customer not found!");
            }
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewCustomers.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridViewCustomers.Columns["colDelete"].Index)
                {
                    var id = Guid.Parse(selectedRow.Cells["colId"].Value.ToString());
                    DeleteCustomer(id);
                }
                else
                {
                    txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                    txtName.Text = selectedRow.Cells["colName"].Value.ToString();
                    txtEmail.Text = selectedRow.Cells["colEmail"].Value.ToString();
                    txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
                }
            }

        }

       
    }
}
