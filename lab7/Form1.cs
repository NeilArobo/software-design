using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int pageSize = 10;
        private int currentPage = 1;

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < 1)
            {
                currentPage++;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }
            else
            {
                btnNextPage.Enabled = false;
            }
        }
        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }
            else
            {
                btnPreviousPage.Enabled = false;
            }
        }

        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };
                    context.Authors.Add(author);
                    context.Books.Add(book);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtboxAuthorName.Text.Trim();
            var bookTitle = txtboxBookTitle.Text.Trim();
            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }

        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }
        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully.");
            }
        }
    }
}
