using BookHeaven2.Data.Models;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtGenre;
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
            dataGridViewBooks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colGenre = new DataGridViewTextBoxColumn();
            colISBN = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddBook = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtISBN = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblISBN = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colAuthor, colGenre, colISBN, colPrice, colQuantity, colDelete });
            dataGridViewBooks.Location = new Point(40, 70);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(1067, 469);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.Width = 130;
            // 
            // colAuthor
            // 
            colAuthor.HeaderText = "Author";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.Width = 125;
            // 
            // colGenre
            // 
            colGenre.HeaderText = "Genre";
            colGenre.MinimumWidth = 6;
            colGenre.Name = "colGenre";
            colGenre.Width = 125;
            // 
            // colISBN
            // 
            colISBN.HeaderText = "ISBN";
            colISBN.MinimumWidth = 6;
            colISBN.Name = "colISBN";
            colISBN.Width = 125;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 135;
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
            // btnAddBook
            // 
            btnAddBook.BackColor = SystemColors.InactiveCaption;
            btnAddBook.Location = new Point(1156, 508);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 31);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(1156, 151);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 3;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(1156, 214);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 27);
            txtAuthor.TabIndex = 4;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(1156, 276);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(200, 27);
            txtGenre.TabIndex = 5;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(1156, 336);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(200, 27);
            txtISBN.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1156, 400);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1156, 464);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 9;
            label1.Text = "Book Management";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(1156, 128);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(1156, 191);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(1156, 253);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 12;
            lblGenre.Text = "Genre";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(1162, 313);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 13;
            lblISBN.Text = "ISBN";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(1156, 377);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(1156, 441);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(60, 20);
            lblQty.TabIndex = 15;
            lblQty.Text = "Quanity";
            lblQty.Click += lblQty_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Location = new Point(1281, 508);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdateClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(1156, 93);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1156, 70);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 18;
            label2.Text = "Id";
            // 
            // BookForm
            // 
            ClientSize = new Size(1373, 566);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblISBN);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtISBN);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(btnAddBook);
            Controls.Add(dataGridViewBooks);
            Name = "BookForm";
            Text = "Book List";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
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
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }


        private async void btnUpdateClick(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a book to update");
                return;
            }
            var newBook = new Book
            {
                Id = Guid.Parse(txtId.Text),
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = txtGenre.Text,
                ISBN = txtISBN.Text,
                Price = decimal.TryParse(txtPrice.Text, out var price) ? price : 0,
                Quantity = int.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0,
                SupplierId = null
            };

            var updated = await _bookService.UpdateBook(newBook);
            if (updated != null && updated > 0)
            {
                MessageBox.Show("Book updated successfully");
                BookForm_Load(sender, e);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Book update failed");
            }
        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
