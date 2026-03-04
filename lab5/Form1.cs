using Microsoft.EntityFrameworkCore;

namespace lab5
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
            public virtual ICollection<Books> Books { get; set; }
        }

        public class Books
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }

        }

        public void AddAuthorWithBooks(string auhtorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = auhtorName };
                var book = new Books { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
                MessageBox.Show("Author and Book added successfully!");

            }
        }
        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return booksWithAuthors;
            }
        }

        public void UpdateBookAndAuthors(int bookId, string newTitle, string newAuthor)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthor;
                    context.SaveChanges();
                    MessageBox.Show("Book title and author updated successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }


        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            BookBox.DataSource = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookBox.Text);
            UpdateBookAndAuthors(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully!");
        }

        //Task 7
        public void DeleteBookAndAuthors() 
        {
            using (var context = new BookstoreContext()) 
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == 1);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.Authors.Remove(book.Author);
                    context.SaveChanges();
                    MessageBox.Show("Book and Author deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var booksByAuthor = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksByAuthor;
            }

        }



    }
}
