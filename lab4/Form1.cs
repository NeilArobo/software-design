
namespace lab4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void ProcessBooksRecursive(Book[] books, int index)
        {
            if (index >= books.Length)
            {
                return;
            }

            ProcessBooksRecursive(books, index + 1);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            //Testing the classes
            Book myBook = new Book { Title = "Harry Potter and the Order of the Phoenix", Author = "JK Rowling" };
            Magazine myMagazine = new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 };
            Ebook myEbook = new Ebook { Title = "For Hire: A Damn Good Kisser", Author = "Ariesa Jane Domingo", FilesizeMB = 5 };
            AudioBook myAudioBook = new AudioBook { Title = "With the Fire on High", Narrator = "Elizabeth Acevedo", Duration = new TimeSpan(7, 27, 0) };
            Book[] books = new Book[] { myBook, myMagazine, myEbook, myAudioBook };
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }
    }
}
