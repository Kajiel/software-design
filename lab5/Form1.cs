using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var context = new BookstoreContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
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

        public void AddAuthorWithBooks(string auhtorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = auhtorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
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
        //==========================================================================================================
        //Task 7
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
        //==========================================================================================================
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
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text))
            {
                var books = SearchBooksByAuthor(txtAuthorName.Text);
                BookBox.DataSource = books;
            }
            else
            {
                var books = GetBooksWithAuthors();
                BookBox.DataSource = books;
            }

        }

        //==========================================================================================================
        //Task 6
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookID == 1);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book and Author deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookBox.Text, out int bookId))
            {
                DeleteBook(bookId);
                var books = GetBooksWithAuthors();
                BookBox.DataSource = null;
                BookBox.DataSource = books;
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }
        //==========================================================================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text) && !string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Please enter both Author Name and Book Title.");
                return;
            }
            AddAuthorWithBooks(txtAuthorName.Text, txtBookTitle.Text);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookBox.Text, out int bookId))
            {
                UpdateBookAndAuthors(bookId, txtBookTitle.Text, txtAuthorName.Text);
                var books = GetBooksWithAuthors();
                BookBox.DataSource = null;
                BookBox.DataSource = books;
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }
    }
}
