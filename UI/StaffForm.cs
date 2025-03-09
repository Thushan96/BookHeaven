using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
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
            dataGridViewUsers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddCustomer = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            label2 = new Label();
            lblUserName = new Label();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblPassword = new Label();
            txtPassord = new TextBox();
            this.btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colRole, colDelete });
            dataGridViewUsers.Location = new Point(183, 71);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(558, 421);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellContentClick;
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
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.InactiveCaption;
            btnAddCustomer.Location = new Point(996, 421);
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
            btnUpdate.Location = new Point(1118, 421);
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
            lblRole.Location = new Point(996, 317);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 20;
            lblRole.Text = "Role";
            lblRole.Click += labelEmail_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(996, 353);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(197, 28);
            cmbRole.TabIndex = 21;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(996, 248);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // txtPassord
            // 
            txtPassord.Location = new Point(996, 271);
            txtPassord.Name = "txtPassord";
            txtPassord.Size = new Size(200, 27);
            txtPassord.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnBack.Location = new Point(1118, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(94, 37);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += this.btnBack_Click;
            // 
            // StaffForm
            // 
            ClientSize = new Size(1373, 566);
            Controls.Add(this.btnBack);
            Controls.Add(txtPassord);
            Controls.Add(lblPassword);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblUserName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(btnAddCustomer);
            Controls.Add(dataGridViewUsers);
            Name = "StaffForm";
            Text = "Book List";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
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
            txtPassord.Text = "";
            cmbRole.SelectedIndex = -1;

        }

        private async void StaffForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
            var users = await userService.GetAllUsersAsync();
            dataGridViewUsers.Rows.Clear();
            foreach (var user in users)
            {
                dataGridViewUsers.Rows.Add(
                    user.Id,
                    user.Username,
                    user.Role
                );
            }
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
            try
            {
                if (cmbRole.SelectedValue == null)
                {
                    MessageBox.Show("Please select a valid role.");
                    return;
                }

                if (!Enum.TryParse(cmbRole.SelectedValue.ToString(), out UserRole selectedRole))
                {
                    MessageBox.Show("Invalid role selection.");
                    return;
                }

                if (txtPassord.Text == null || txtPassord.Text == "")
                {
                    MessageBox.Show("Please enter valid password.");
                    return;
                }

                var user = new AppUser
                {
                    Id = Guid.NewGuid(),
                    Username = txtUserName.Text,
                    PasswordHash = txtPassord.Text,
                    Role = selectedRole
                };

                await userService.CreateUserAsync(user);

                StaffForm_Load(sender, e);

                MessageBox.Show("User added successfully!");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }
        }

        private async void btnUpdateClick(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a User to update");
                return;
            }
            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            if (!Enum.TryParse(cmbRole.SelectedValue.ToString(), out UserRole selectedRole))
            {
                MessageBox.Show("Invalid role selection.");
                return;
            }

            try
            {
                var user = new AppUser
                {
                    Id = Guid.Parse(txtId.Text),
                    Username = txtUserName.Text,
                    PasswordHash = txtPassord.Text,
                    Role = selectedRole
                };
                MessageBox.Show(user.PasswordHash);
                await userService.UpdateUserAsync(user);

                MessageBox.Show("Customer updated successfully");
                StaffForm_Load(sender, e);
                clearTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("User update failed", (ex.Message));

            }
        }


        private async void DeleteUser(Guid id)
        {


            if (id != null)
            {
                try
                {
                    await userService.DeleteUserAsync(id);

                    StaffForm_Load(this, EventArgs.Empty);
                    clearTextBoxes();

                    MessageBox.Show("User deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting User: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("User not found!");
            }

        }


        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewUsers.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridViewUsers.Columns["colDelete"].Index)
                {
                    var id = Guid.Parse(selectedRow.Cells["colId"].Value.ToString());
                    DeleteUser(id);
                }
                else
                {
                    txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                    txtUserName.Text = selectedRow.Cells["colUsername"].Value.ToString();
                    string roleText = selectedRow.Cells["colRole"].Value.ToString();
                    if (Enum.TryParse(roleText, out UserRole selectedRole))
                    {
                        cmbRole.SelectedItem = selectedRole;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
