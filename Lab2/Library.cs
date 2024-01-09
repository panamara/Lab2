using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2;

    internal class Library
    {
        private List<Book> catalog;

        public Library()
        {
            catalog = new List<Book>();
        }

        public void AddBook(Book book)
        {
            catalog.Add(book);
            Console.WriteLine("\nКнига добавлена в каталог");
        }

        public void SearchByTitle(string title)
        {
            var result = catalog.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            DisplayResults(result);
        }

        public void SearchByAuthor(string author)
        {
            var result = catalog.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
            DisplayResults(result);
        }

        public void SearchByISBN(string isbn)
        {
            var result = catalog.Where(b => b.ISBN == isbn);
            DisplayResults(result);
        }

        public void SearchByTags(string[] tags)
        {
            var result = catalog.OrderByDescending(b => tags.Count(k => b.Title.Contains(k, StringComparison.OrdinalIgnoreCase) ||
                                                                       b.Author.Contains(k, StringComparison.OrdinalIgnoreCase) ||
                                                                       b.Genres.Any(g => g.Contains(k, StringComparison.OrdinalIgnoreCase)) ||
                                                                       b.Annotation.Contains(k, StringComparison.OrdinalIgnoreCase)))
                               .ThenBy(b => b.Title);
            DisplayResults(result);
        }

        private void DisplayResults(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

