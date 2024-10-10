using static lab3.TextBook.Books;

namespace lab3
{
    public partial class TextBook : Form
    {
        public TextBook()
        {
            InitializeComponent();
        }

        public class Books
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }

            public class Magazine : Books
            {
                public int IssueNumber { get; set; }

                public override string GetInfo()
                {
                    return $"{Title} by - Issue #{IssueNumber}";
                }

            }

            public class Ebook : Books
            {
                public double FileSize { get; set; }
                public string Format { get; set; }

                public override string GetInfo()
                {
                    return $"{Title} by {Author} - {FileSize}MB ({Format}";
                }
            }
        }

        //Polymorphic Function to process array of Books
        private void ProcessBooks(Books[] books)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("=== Book Collection ===");
            listBox1.Items.Add("");

            foreach (Books book in books) 
            {
                listBox1.Items.Add(book.GetInfo());

                listBox1.Items.Add($" Type: {book.GetType().Name}");
                listBox1.Items.Add("");

            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Books[] bookCollection = new Books[]
            {
                new Books
                {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald"

                },
                new Ebook
                {
                    Title = "1984",
                    Author = "George Orwell",
                    FileSize = 1.5,
                    Format = "PDF"
                },
                new Magazine
                {
                    Title = "Tech Weekly",
                    Author = "John Doe",
                    IssueNumber = 45
                },
                new Ebook
                {
                    Title = "The Pragmatic Programmer",
                    Author = "Andrew Hunt and David Thomas",
                    FileSize = 2.3,
                    Format = "EPUB"
                }

            };
            ProcessBooks(bookCollection);
        }
    }
}
