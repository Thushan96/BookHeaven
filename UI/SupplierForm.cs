using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    partial class SupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtName;
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
            dataGridViewSuppliers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colBooks = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddBooks = new Button();
            txtName = new TextBox();
            txtContact = new TextBox();
            label1 = new Label();
            lblConatct = new Label();
            btnUpdateBooks = new Button();
            txtId = new TextBox();
            label2 = new Label();
            lblName = new Label();
            dataGridViewBooks = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            lblBooks = new Label();
            cmbBooks = new ComboBox();
            this.btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colContact, colBooks, colDelete });
            dataGridViewSuppliers.Location = new Point(130, 62);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.Size = new Size(741, 264);
            dataGridViewSuppliers.TabIndex = 0;
            dataGridViewSuppliers.CellClick += dataGridViewSuppliers_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 140;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 140;
            // 
            // colContact
            // 
            colContact.HeaderText = "Conatct No";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.Width = 140;
            // 
            // colBooks
            // 
            colBooks.HeaderText = "Books";
            colBooks.MinimumWidth = 6;
            colBooks.Name = "colBooks";
            colBooks.Resizable = DataGridViewTriState.True;
            colBooks.SortMode = DataGridViewColumnSortMode.Automatic;
            colBooks.Width = 125;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 140;
            // 
            // btnAddBooks
            // 
            btnAddBooks.BackColor = SystemColors.InactiveCaption;
            btnAddBooks.Location = new Point(1003, 452);
            btnAddBooks.Name = "btnAddBooks";
            btnAddBooks.Size = new Size(75, 31);
            btnAddBooks.TabIndex = 1;
            btnAddBooks.Text = "Add";
            btnAddBooks.UseVisualStyleBackColor = false;
            btnAddBooks.Click += btnAddBook_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(993, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 3;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(993, 299);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 27);
            txtContact.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 18);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 9;
            label1.Text = "Supplier Management";
            // 
            // lblConatct
            // 
            lblConatct.AutoSize = true;
            lblConatct.Location = new Point(996, 276);
            lblConatct.Name = "lblConatct";
            lblConatct.Size = new Size(84, 20);
            lblConatct.TabIndex = 12;
            lblConatct.Text = "Contact No";
            lblConatct.Click += lblConatct_Click;
            // 
            // btnUpdateBooks
            // 
            btnUpdateBooks.BackColor = SystemColors.Info;
            btnUpdateBooks.Location = new Point(1132, 452);
            btnUpdateBooks.Name = "btnUpdateBooks";
            btnUpdateBooks.Size = new Size(75, 31);
            btnUpdateBooks.TabIndex = 16;
            btnUpdateBooks.Text = "Update";
            btnUpdateBooks.UseVisualStyleBackColor = false;
            btnUpdateBooks.Click += btnUpdateSupplier_Click;
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
            lblName.Location = new Point(996, 183);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridViewBooks.Location = new Point(48, 341);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(926, 222);
            dataGridViewBooks.TabIndex = 1;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Book ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Title";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Author";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Genre";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "ISBN";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Price";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Quantity";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
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
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Location = new Point(996, 354);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(49, 20);
            lblBooks.TabIndex = 20;
            lblBooks.Text = "Books";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(1003, 390);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(190, 28);
            cmbBooks.TabIndex = 21;
            cmbBooks.MouseClick += cmbBooksMouseClick;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnBack.Location = new Point(1113, 578);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(94, 37);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += this.btnBack_Click;
            // 
            // SupplierForm
            // 
            ClientSize = new Size(1373, 636);
            Controls.Add(this.btnBack);
            Controls.Add(cmbBooks);
            Controls.Add(lblBooks);
            Controls.Add(dataGridViewBooks);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnUpdateBooks);
            Controls.Add(lblConatct);
            Controls.Add(label1);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(btnAddBooks);
            Controls.Add(dataGridViewSuppliers);
            Name = "SupplierForm";
            Text = "Book List";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private async void SupplierForm_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.Visible = false;
            await Task.Delay(1000);

            var suppliers = await supplierService.GetAllSuppliersAsync();
            dataGridViewSuppliers.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                dataGridViewSuppliers.Rows.Add(
                    supplier.Id,
                    supplier.Name,
                    supplier.ContactInfo,
                    "View Books"
                );
            }
        }

        private void InitializeDataGridViewBooks()
        {
            dataGridViewBooks.Columns.Clear();
            dataGridViewBooks.Columns.Add("colBookId", "Book ID");
            dataGridViewBooks.Columns.Add("colTitle", "Title");
            dataGridViewBooks.Columns.Add("colAuthor", "Author");
            dataGridViewBooks.Columns.Add("colGenre", "Genre");
            dataGridViewBooks.Columns.Add("colISBN", "ISBN");
            dataGridViewBooks.Columns.Add("colPrice", "Price");
            dataGridViewBooks.Columns.Add("colQuantity", "Quantity");
        }


        private async void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var supplierId = (Guid)dataGridViewSuppliers.Rows[e.RowIndex].Cells["colId"].Value;
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSuppliers.Columns["colBooks"].Index)
            {
                LoadBooksForSupplier(supplierId);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSuppliers.Columns["colDelete"].Index)
            {
                await DeleteSupplier(supplierId);
            }
            else
            {
                var selectedRow = dataGridViewSuppliers.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                txtName.Text = selectedRow.Cells["colName"].Value.ToString();
                txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
            }
        }

        private async void LoadBooksForSupplier(Guid supplierId)
        {
            dataGridViewBooks.Visible = true;

            var books = await bookService.GetBooksBySupplier(supplierId);
            dataGridViewBooks.Rows.Clear();

            foreach (var book in books)
            {
                dataGridViewBooks.Rows.Add(
                    book.Id,
                    book.Title,
                    book.Author,
                    book.Genre,
                    book.ISBN,
                    book.Price,
                    book.Quantity
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
            txtName.Text = "";
            txtContact.Text = "";
            dataGridViewBooks.Rows.Clear();
            dataGridViewBooks.Visible = false;
            cmbBooks.SelectedIndex = -1;
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

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task LoadBooks()
        {
            var books = await bookService.GetAllBooks();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Id";
            cmbBooks.SelectedIndex = -1;
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter supplier name and contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var supplier = new Supplier
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                ContactInfo = txtContact.Text
            };

            await supplierService.CreateSupplierAsync(supplier);

            if (cmbBooks.SelectedValue != null)
            {
                var selectedBookId = (Guid)cmbBooks.SelectedValue;
                var selectedBook = await bookService.GetBookById(selectedBookId);

                if (selectedBook != null)
                {
                    selectedBook.SupplierId = supplier.Id;

                    var updateResult = await bookService.UpdateBook(selectedBook);
                    if (!updateResult.HasValue)
                    {
                        MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show("Supplier added and book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadSuppliers();
            ClearTextBoxes();
        }



        private async void cmbBooksMouseClick(object sender, MouseEventArgs e)
        {
            await LoadBooks();
        }

        private async void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a supplier to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var supplierId = Guid.Parse(txtId.Text);
            var supplier = await supplierService.GetSupplierByIdAsync(supplierId);

            if (supplier != null)
            {
                supplier.Name = txtName.Text;
                supplier.ContactInfo = txtContact.Text;
                if (cmbBooks.SelectedValue != null)
                {
                    var selectedBookId = (Guid)cmbBooks.SelectedValue;
                    var selectedBook = await bookService.GetBookById(selectedBookId);

                    if (selectedBook != null && !supplier.Books.Any(b => b.Id == selectedBookId))
                    {
                        supplier.Books.Add(selectedBook);
                        selectedBook.SupplierId = supplier.Id;
                        await bookService.UpdateBook(selectedBook);
                    }
                }

                await supplierService.UpdateSupplierAsync(supplier);
                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadSuppliers();
                ClearTextBoxes();
            }
        }



        private async Task LoadSuppliers()
        {
            var suppliers = await supplierService.GetAllSuppliersAsync();
            dataGridViewSuppliers.Rows.Clear();

            foreach (var supplier in suppliers)
            {
                dataGridViewSuppliers.Rows.Add(
                    supplier.Id,
                    supplier.Name,
                    supplier.ContactInfo,
                    "View Books"
                );
            }
        }

        private async Task DeleteSupplier(Guid id)
        {
            var supplier = await supplierService.GetSupplierByIdAsync(id);
            if (supplier != null)
            {
                var books = await bookService.GetBooksBySupplier(id);

                if (books != null)
                {
                    foreach (var book in books)
                    {
                        book.SupplierId = null;
                        await bookService.UpdateBook(book);
                    }
                }
                await supplierService.DeleteSupplierAsync(id);

                MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadSuppliers();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
