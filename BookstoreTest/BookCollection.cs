using Microsoft.VisualStudio.TestTools.UnitTesting;
using static lab3.AudioBook;

namespace BookstoreTest
{
    [TestClass]
    public sealed class BookCollection
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programing", Author = "John Smith" };
            Assert.AreEqual("C# Programing", book.Title);
            Assert.AreEqual("John Smith", book.Author);

        }
        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }
        [TestMethod]
        public void TestEbookCreation()
        {
            Ebook ebook = new Ebook { Title = "1984", Author = "George Orwell", FileSize = 1.5, Format = "PDF" };
            Assert.AreEqual("1984", ebook.Title);
            Assert.AreEqual("George Orwell", ebook.Author);
            Assert.AreEqual(1.5, ebook.FileSize);
            Assert.AreEqual("PDF", ebook.Format);
        }
    }
}
