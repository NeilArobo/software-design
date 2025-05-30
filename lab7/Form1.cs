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
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);

            if (books.Count == 0)
            {
                currentPage--;
                btnNextPage.Enabled = false;
            }
            else
            {
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }

            btnPreviousPage.Enabled = true;
        }
        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            var books = await GetBooksByPageAsync(currentPage);

            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";

            btnPreviousPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = true;
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

        public async Task<List<string>> SearchBooksByTitleAsync(string title)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = await context.Books
                        .Include(b => b.Author)
                        .Where(b => EF.Functions.Like(b.Title, $"%{title}%"))
                        .Select(b => $"{b.Title} by {b.Author.Name}")
                        .ToListAsync();

                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}");
                return new List<string>();
            }
        }

        private async void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchTerm = txtboxBookTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a title to search.");
                return;
            }

            var results = await SearchBooksByTitleAsync(searchTerm);

            if (results.Any())
            {
                listBoxBooks.DataSource = results;
                lblPageNumber.Text = "Search Results";
            }
            else
            {
                MessageBox.Show("No books found matching the title.");
                listBoxBooks.DataSource = null;
            }
        }

        public async Task ImportBooksFromFileAsync(string filePath)
        {
            var lines = await File.ReadAllLinesAsync(filePath);
            int total = lines.Length;

            using (var context = new BookstoreContext())
            {
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line) || !line.Contains(" by ")) continue;

                    var parts = line.Split(" by ");
                    if (parts.Length != 2) continue;

                    string title = parts[0].Trim();
                    string authorName = parts[1].Trim();

                    var author = await context.Authors
                        .FirstOrDefaultAsync(a => a.Name == authorName);

                    if (author == null)
                    {
                        author = new Author { Name = authorName };
                        context.Authors.Add(author);
                        await context.SaveChangesAsync();
                    }

                    var book = new Book { Title = title, AuthorID = author.AuthorID };
                    context.Books.Add(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Book Data File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await ImportBooksFromFileAsync(openFileDialog.FileName);
                    MessageBox.Show("Books imported successfully!");
                }
            }
        }
    }
}
