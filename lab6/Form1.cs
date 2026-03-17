using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Threading.Tasks;
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

        public async Task<List<string>> GetBookAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress?.Report(10);

                var bookEntities = await context.Books.Include(b => b.Author).ToListAsync();

                progress?.Report(50);
                await Task.Delay(500);

                var books = bookEntities.Select(b => $"{b.Title} by {b.Author.Name}").ToList();

                progress?.Report(100);

                return books;
            }

        }

        public async Task SaveBookAsync(string booktitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = booktitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(percent => progressBar1.Value = percent);
            var books = await GetBookAsync(progress);
            listBoxBooks.DataSource = books;
        }

        private async void btnAddBooks_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book added successfully!");
        }

        private async void btnUpdateBooks_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                btnUpdateBooks.Enabled = false;

                using (var context = new BookstoreContext())
                {

                    var book = await context.Books
                        .Include(b => b.Author)
                        .SingleOrDefaultAsync(b => b.BookID == bookId);


                    if (book != null)
                    {

                        book.Title = txtBookTitle.Text;
                        book.Author.Name = txtAuthorName.Text;

                        await context.SaveChangesAsync();
                        MessageBox.Show("Book and Author updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }

                btnUpdateBooks.Enabled = true;
            }
        }

        private async void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                btnDeleteBooks.Enabled = false;

                using (var context = new BookstoreContext())
                {
                    // FindAsync is perfect here since we only need the Book entity
                    var book = await context.Books.FindAsync(bookId);

                    if (book != null)
                    {
                        context.Books.Remove(book);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }

                btnDeleteBooks.Enabled = true;
            }
        }

        private async void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBookTitle.Text;
            using (var context = new BookstoreContext())
            {

                var searchResults = await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(searchTerm))
                    .ToListAsync();
                var formattedBooks = searchResults
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                listBoxBooks.DataSource = formattedBooks;
            }
        }
    }
}
