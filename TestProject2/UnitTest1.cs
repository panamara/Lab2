
namespace Lab2.TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void LibrarySearchTest()
        {
            var library = new Library();
            var bookone = new BookMaker();
            var book = bookone
                .SetTitle("Name")
                .SetAuthor("AuthorName")
                .SetGenres(new[] { "Adventure" })
                .SetISBN("548754-23-1")
                .SetPublicationDate(new DateTime(1954, 7, 29))
                .SetAnnotation("Something")
                .SetTags(new[] { "classic" })
                .Build();
            library.AddBook(book);
            Assert.Equal(book, library.SearchByTitle("Name").First());
        }

    }
}