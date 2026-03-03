using lab3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static lab3.AudioBook;
namespace BookstoreTest;

[TestClass]
public class PolymorphismTests
{
    [TestMethod]
    public void TestPolymorphism_GetInfo_Method()
    {
        Book[] bookCollection = new Book[]
        {
            new Book{ Title = "Generic Book", Author = "John Smith" },
            new Magazine{ Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
            new Ebook{ Title = "C# Programming", Author = "George Orwell", FileSize = 5, Format = "PDF" }
        };

        Assert.AreEqual("Generic Book by John Smith", bookCollection[0].GetInfo());
        Assert.AreEqual("Tech Weekly - Issue #12", bookCollection[1].GetInfo());
        Assert.AreEqual("C# Programming by George Orwell - 5MB (PDF)", bookCollection[2].GetInfo());

    }
    //Task 2
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestInvalidMagazineCreation()
    {
        Magazine magazine = new Magazine { Title = "Invalid", Author = "Jane Doe", IssueNumber = -1 };

    }
    //Task 3
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Book_EmptyTitle_ShouldThrowExeption()
    {
        Book book = new Book { Title = "", Author = "John Doe" };

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Book_WhitespaceAuthor_ShouldThrowExeption()
    {
        Book book = new Book { Title = "   ", Author = "John Doe" };

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Magazine_NegativeIssueNumber_ShouldFail()
    {
        Magazine magazine = new Magazine { Title = "Tech News", Author = "Jane Smith", IssueNumber = -5 };
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Textbook_EmptySubject_ShouldThrowException()
    {
        Textbook textbook = new Textbook { Title = "Math 101", Author = "Dr. Smith", Subject = "" };
    }
}
