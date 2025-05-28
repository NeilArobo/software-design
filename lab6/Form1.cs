using System.Web;
using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();
            listBoxBooks.DataSource = books;
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtboxAuthorName.Text.Trim();
            var bookTitle = txtboxBookTitle.Text.Trim();
            await SaveBookAsync(bookTitle, authorName);
            MessageBox.Show("Book and Author saved successfully.");
        }

        public async Task<bool> DeleteBookWithBookIDAsync(int id)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(id);
                if (book == null)
                    return false;

                context.Books.Remove(book);
                await context.SaveChangesAsync();
                return true;
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxBookID.Text, out int bookId))
            {
                bool deleted = await DeleteBookWithBookIDAsync(bookId);

                if (deleted)
                    MessageBox.Show("Book deleted successfully.");
                else
                    MessageBox.Show($"Book with ID {bookId} not found.");
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }
    }
}
