using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class AsynchronousUpdate : Form
    {
        public AsynchronousUpdate()
        {
            InitializeComponent();
        }
        public async Task<bool> UpdateBookAsync(string currentTitle, string currentAuthor, string newTitle, string newAuthor)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books
                    .Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.Title == currentTitle && b.Author.Name == currentAuthor);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return false;
                }

                var result = MessageBox.Show("Do you want to update this book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthor;
                    await context.SaveChangesAsync();
                    return true;
                }

                return false;
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBookAsync(lblBookTitle.Text, lblAuthorName.Text, txtboxBookTitle.Text.Trim(), txtboxAuthorName.Text.Trim());
        }
    }
}
