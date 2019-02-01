using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternWorkbook.Library.Builder;

namespace PatternWorkbook.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void Build1()
        {
            Book a = new Book.BookBuilder { Pages = 10, Title = "Book A!" }.Build();

            Assert.IsTrue(a.Pages == 10);
            Assert.IsTrue(a.Title.Contains("A!"));
        }
    }
}
