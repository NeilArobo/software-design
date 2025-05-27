using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4
{
    //Task 1
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 12
            };

            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }

        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            // Arrange: Create an array of Book objects that includes different derived types
            Book[] books = new Book[]
            {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new Ebook { Title = "Learn C#", Author = "Mark Jones", FilesizeMB = 5 }
            };

            // Act and Assert: Check the results of the GetInfo method for each type
            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
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
        public void TestInvalidBookCreation()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                var book = new Book { Title = "Invalid", Author = "John Doe" };
            });
            Assert.AreEqual("Title cannot be empty.", exception.Message);
        }

        [TestMethod]
        public void TestNegativeIssueNumberMagazineCreation()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                var magazine = new Magazine { Title = "", Author = "John Doe", IssueNumber = -5 };
            });
            Assert.AreEqual("Issue number cannot be negative.", exception.Message); // Issue number must be postive
        }

        [TestMethod]
        public void TestInvalidTextBookCreation()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                var textbook = new TextBook
                {
                    Title = "Invalid",
                    Author = "John Doe",
                    Subject = ""
                };
            });
            Assert.AreEqual("Subject cannot be empty.", exception.Message);
        }
    }
}
