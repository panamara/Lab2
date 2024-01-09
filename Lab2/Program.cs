namespace Lab2;
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nГлавное меню:");
                Console.WriteLine("1. Добавить книгу в каталог");
                Console.WriteLine("2. Найти по названию");
                Console.WriteLine("3. Найти по автору");
                Console.WriteLine("4. Найти по ISBN");
                Console.WriteLine("5. Найти по ключевым словам (тегам)");
                Console.WriteLine("6. Выход");

                Console.Write("Введите ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBookToCatalog(library);
                        break;
                    case "2":
                        SearchByTitle(library);
                        break;
                    case "3":
                        SearchByAuthor(library);
                        break;
                    case "4":
                        SearchByISBN(library);
                        break;
                    case "5":
                        SearchByTags(library);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор, введите значение от 1 до 6");
                        break;
                }
            }
        }

        static void AddBookToCatalog(Library library)
        {
            Book book = new Book();

            Console.Write("Введите название: ");
            book.Title = Console.ReadLine();

            Console.Write("Введите автора: ");
            book.Author = Console.ReadLine();

            Console.Write("Введите жанры через запятую: ");
            string[] genres = Console.ReadLine().Split(',');
            book.Genres = genres.Select(g => g.Trim()).ToList();

            Console.Write("Введите дату публикации (год-месяц-день): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                book.PublicationDate = date;
            }
            else
            {
                Console.WriteLine("Неверный формат даты");
                book.PublicationDate = DateTime.MinValue;
            }

            Console.Write("Введите аннотацию: ");
            book.Annotation = Console.ReadLine();

            Console.Write("Введите ISBN: ");
            book.ISBN = Console.ReadLine();

            Console.Write("Введите теги через пробел: ");
            string[] tags = Console.ReadLine().Split(' ');
            book.Tags = tags.Select(g => g.Trim()).ToList();

            library.AddBook(book);
        }

        static void SearchByTitle(Library library)
        {
            Console.Write("Введите название или его фрагмент: ");
            string title = Console.ReadLine();
            library.SearchByTitle(title);
        }

        static void SearchByAuthor(Library library)
        {
            Console.Write("Введите имя автора или его фрагмент: ");
            string author = Console.ReadLine();
            library.SearchByAuthor(author);
        }

        static void SearchByISBN(Library library)
        {
            Console.Write("Введите ISBN: ");
            string isbn = Console.ReadLine();
            library.SearchByISBN(isbn);
        }

        static void SearchByTags(Library library)
        {
            Console.Write("Введите теги через пробел: ");
            string[] tags = Console.ReadLine().Split(' ');
            library.SearchByTags(tags);
        }
    }

