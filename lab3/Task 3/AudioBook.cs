using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class AudioBook : Form
    {
        public AudioBook()
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
                return $"{Title} - Issue #{IssueNumber}";
            }
        }
        public class Ebook : Book
        {
            public double FileSize { get; set; }
            public string Format { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - {FileSize}MB ({Format})";
            }
        }

        //Polymorphic Function to process array of Books
        private void ProcessBooks(Book[] books) 
        {
            ListAudioBook.Items.Clear();
            ListAudioBook.Items.Add("=== Book Collection ===");
            ListAudioBook.Items.Add("");

            foreach (Book book in books)
            {
                ListAudioBook.Items.Add(book.GetInfo());

                ListAudioBook.Items.Add($"  Type: {book.GetType().Name}");
                ListAudioBook.Items.Add("");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Book[] bookCollection = new Book[]
            {
                new Book
                {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald"

                },

                new Magazine
                {
                    Title = "National Geographic",
                    Author = "Various",
                    IssueNumber = 202
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
                    Title = "Time",
                    Author = "Various",
                    IssueNumber = 45
                },

            };
            ProcessBooks(bookCollection);
        }
    }
}
