using System.Web;
using Microsoft.EntityFrameworkCore;
using static lab6.Form1;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;

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

        //Asynchronous Data Fetching and Operation Progress
        public async Task<List<string>> GetBooksAsync(IProgress<int> progress = null)
        {
            using (var context = new BookstoreContext())
            {
                var totalBooks = await context.Books.CountAsync();
                var booksList = new List<string>();

                int processed = 0;
                var books = await context.Books.Include(b => b.Author).ToListAsync();

                foreach (var book in books)
                {
                    booksList.Add($"{book.BookID} \t {book.Title} by {book.Author.Name}");

                    processed++;
                    int percent = totalBooks > 0 ? (processed * 100 / totalBooks) : 100;
                    progress?.Report(percent);

                    await Task.Delay(10);
                }

                return booksList;
            }
        }
        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Visible = true;

            var progress = new Progress<int>(value =>
            {
                progressBar.Value = Math.Min(value, 100);
            });

            var books = await GetBooksAsync(progress);
            listBoxBooks.DataSource = books;

            progressBar.Value = 100; // Ensure full on complete
            await Task.Delay(300);   // Optional short delay
            progressBar.Visible = false;
        }

        //Add Asynchronous Data Saving
        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var existingAuthor = await context.Authors
                    .FirstOrDefaultAsync(a => a.Name == authorName);

                Author author;

                if (existingAuthor != null)
                {
                    author = existingAuthor;
                }
                else
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                    await context.SaveChangesAsync(); // Save now to generate AuthorID
                }

                var book = new Book { Title = bookTitle, AuthorID = author.AuthorID };
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

        //Asynchronous Delete Operation
        public async Task<bool> DeleteBookWithBookIDAsync(int id)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == id);
                if (book == null)
                    return false;

                var author = book.Author;

                context.Books.Remove(book);
                await context.SaveChangesAsync();

                bool authorHasNoMoreBooks = !await context.Books.AnyAsync(b => b.AuthorID == author.AuthorID);
                if (authorHasNoMoreBooks)
                {
                    context.Authors.Remove(author);
                    await context.SaveChangesAsync();
                }

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

        //Asynchronous Search Operation
        public async Task<List<string>> SearchBooksByTitleAsync(string title)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .Where(b => EF.Functions.Like(b.Title, $"%{title}%"))
                    .Select(b => $"{b.BookID} \t {b.Title} by {b.Author.Name}")
                    .ToListAsync();
                return books;
            }
        }

        private async void btnSearchBook_Click(object sender, EventArgs e)
        {
            var titleToSearch = txtboxBookTitle.Text.Trim();
            if (!string.IsNullOrWhiteSpace(titleToSearch))
            {
                var searchResults = await SearchBooksByTitleAsync(titleToSearch);
                listBoxBooks.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Please enter a book title to search.");
            }
        }

        //SELECT A DATA FROM THE LISTBOX
        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                string selected = listBoxBooks.SelectedItem.ToString();
                var idAndRest = selected.Split('\t');
                if (idAndRest.Length == 2)
                {
                    var titleAndAuthor = idAndRest[1].Trim().Split(new[] { " by " }, StringSplitOptions.None);
                    if (titleAndAuthor.Length == 2)
                    {
                        txtboxBookTitle.Text = titleAndAuthor[0].Trim();
                        txtboxAuthorName.Text = titleAndAuthor[1].Trim();
                    }
                }
            }
        }

        //Asynchronous Update Operation
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            AsynchronousUpdate UpdateForm = new AsynchronousUpdate();
            string currentAuthorName = txtboxAuthorName.Text.Trim();
            string currentBookTitle = txtboxBookTitle.Text.Trim();
            UpdateForm.Show();
            UpdateForm.lblAuthorName.Text = currentAuthorName;
            UpdateForm.lblBookTitle.Text = currentBookTitle;
        }
    }
}
