namespace Task_2___Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Issue {IssueNumber}";
            }
        }
        public class Ebook : Book
        {
            public string Format { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Format: {Format}";
            }
        }
            public void ProcessBooks(Book[] books)
        {
            ProcessBooksRecursive(books, 0);
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
            //Test the Application
            Book myBook = new Book { Title = "Harry Potter and the Order of the Phoenix", Author = "JK Rowling" };
            Magazine myMagazine = new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 };
            Ebook myEbook = new Ebook { Title = "For Hire: A Damn Good Kisser", Author = "Ariesa Jane Domingo", Format = "PDF" };

            Book[] books = new Book[] { myBook, myMagazine, myEbook };
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }
    }
}
