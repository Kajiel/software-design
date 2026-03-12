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

        public void AddAuthorWithBooks(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Books.Add(book);   // adding book is enough; author will be added too
                context.SaveChanges();

                MessageBox.Show($"Saved!\nBookID: {book.BookID}\nAuthorID: {author.AuthorID}");
            }
        }
        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Select(b => $"[{b.BookID}] {b.Title} by {b.Author.Name}")
                    .ToList();
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
        public void UpdateBookAndAuthors(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(b => b.BookID == bookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                // Update title (only if provided)
                if (!string.IsNullOrWhiteSpace(newTitle))
                    book.Title = newTitle;

                // Re-assign author (only if provided)
                if (!string.IsNullOrWhiteSpace(newAuthorName))
                {
                    var existingAuthor = context.Authors
                        .FirstOrDefault(a => a.Name == newAuthorName);

                    if (existingAuthor == null)
                    {
                        existingAuthor = new Author { Name = newAuthorName };
                        context.Authors.Add(existingAuthor);
                    }

                    book.Author = existingAuthor;
                    book.AuthorID = existingAuthor.AuthorID; // optional; EF will handle via navigation too
                }

                context.SaveChanges();
                MessageBox.Show("Book updated successfully!");
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
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(b => b.BookID == bookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                context.Books.Remove(book);
                context.SaveChanges();

                MessageBox.Show("Book deleted successfully!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookBox.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID.");
                return;
            }

            DeleteBook(bookId);

            BookBox.DataSource = GetBooksWithAuthors();
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
            if (!int.TryParse(txtBookBox.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBookTitle.Text) && string.IsNullOrWhiteSpace(txtAuthorName.Text))
            {
                MessageBox.Show("Enter a new title and/or a new author name.");
                return;
            }

            UpdateBookAndAuthors(bookId, txtBookTitle.Text, txtAuthorName.Text);
            BookBox.DataSource = GetBooksWithAuthors();
        }
    }
}
