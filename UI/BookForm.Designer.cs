using System;
using System.Linq;
using System.Windows.Forms;
using BookHeaven2.Services;
using BookHeaven2.Data.Models;

namespace BookHeaven2.UI
{
    public partial class BookForm : Form
    {
        private readonly BookService _bookService;
        private readonly UserRole userRole;

        public BookForm(BookService bookService, UserRole userRole)
        {
            InitializeComponent();
            _bookService = bookService;
            this.userRole = userRole;

        }

        private async void BookForm_Load(object sender, EventArgs e)
        {
            var books = await _bookService.GetAllBooks();
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
            if (userRole == UserRole.SalesClerk)
            {
                btnAddBook.Enabled = false;
                btnUpdate.Enabled = false;
                dataGridViewBooks.Columns["colDelete"].Visible = false;
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                var selectedRow = dataGridViewBooks.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridViewBooks.Columns["colDelete"].Index)
                {
                    var title = selectedRow.Cells["colTitle"].Value.ToString();
                    DeleteBook(title);
                }
                else
                {
                    txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                    txtTitle.Text = selectedRow.Cells["colTitle"].Value.ToString();
                    txtAuthor.Text = selectedRow.Cells["colAuthor"].Value.ToString();
                    txtGenre.Text = selectedRow.Cells["colGenre"].Value.ToString();
                    txtISBN.Text = selectedRow.Cells["colISBN"].Value.ToString();
                    txtPrice.Text = selectedRow.Cells["colPrice"].Value.ToString();
                    txtQuantity.Text = selectedRow.Cells["colQuantity"].Value.ToString();
                }
            }
        }


        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Id = Guid.NewGuid(),
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = txtGenre.Text,
                ISBN = txtISBN.Text,
                Price = decimal.TryParse(txtPrice.Text, out var price) ? price : 0,
                Quantity = int.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0,
                SupplierId = null 
            };

            try
            {
                await _bookService.AddBook(newBook);

                BookForm_Load(sender, e);

                MessageBox.Show("Book added successfully!");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
            }
        }

        private async void DeleteBook(string title)
        {
            var books = await _bookService.GetAllBooks();
            var bookToDelete = books.FirstOrDefault(b => b.Title == title);

            if (bookToDelete != null)
            {
                try
                {
                    await _bookService.DeleteBook(bookToDelete.Id);

                    BookForm_Load(this, EventArgs.Empty);

                    MessageBox.Show("Book deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Book not found!");
            }
        }

        private Label label2;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdate;
        private TextBox txtId;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewTextBoxColumn colISBN;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn colDelete;
        private Button btnBack;
    }
}