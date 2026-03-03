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
            private string _title;
            private string _author;

            public string Title 
            { 
                get => _title;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Title cannot be empty or whitespace.");
                    }
                    _title = value;
                }
            }

            public string Author 
            { 
                get => _author;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Author cannot be empty or whitespace.");
                    }
                    _author = value;
                }
            }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }
        public class Magazine : Book
        {
            private int _issueNumber;
            
            public int IssueNumber 
            { 
                get => _issueNumber;
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Issue number cannot be negative.");
                    }
                    _issueNumber = value;
                }
            }
            
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

        public class Textbook : Book
        {
            private string _subject;

            public string Subject 
            { 
                get => _subject;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Subject cannot be empty or whitespace.");
                    }
                    _subject = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
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
                new Textbook
                {
                    Subject = "Mathematics",
                    Title = "Calculus 101",
                    Author = "Melenia Derek"

                }

            };
            ProcessBooks(bookCollection);
        }
    }
}
