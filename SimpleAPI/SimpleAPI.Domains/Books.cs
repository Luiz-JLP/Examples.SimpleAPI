using SimpleAPI.Domains.Interfaces;
using SimpleAPI.Infrastructure.Interfaces;
using SimpleAPI.Models;

namespace SimpleAPI.Domains
{
    /// <summary>
    /// Book's Domains
    /// </summary>
    public class Books : IBooks
    {
        private readonly IBookData _bookData;

        public Books(IBookData bookData)
        {
            _bookData = bookData;
        }

        /// <summary>
        /// Get a Book by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book Get(Guid id)
        {
            return _bookData.Get(id) ?? throw new ArgumentException("Nenhum item encontrado.", nameof(id));
        }

        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> Get()
        {
            var books = _bookData.Get();

            // It enters the data in the first request.
            if (books == null || !books.Any())
            {
                InitializeDatabase();
                return _bookData.Get();
            }

            return books;
        }



        /// <summary>
        /// Initialize a database
        /// </summary>
        private void InitializeDatabase()
        {
            var list = CreateBooks();
            _bookData.Create(list);
        }

        /// <summary>
        /// List of books for initialization
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Book> CreateBooks()
        {
            var books = new List<Book>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software",
                    Edition = 1,
                    Author = "Eric Evans",
                    PrintLenght = 560,
                    Language = "English",
                    Publisher = "Addison-Wesley Professional",
                    PublicationDate = new DateTime(2003, 8, 20)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    Edition = 1,
                    Author = "Robert C. Martin",
                    PrintLenght = 464,
                    Language = "English",
                    Publisher = "Pearson",
                    PublicationDate = new DateTime(2008,8,1)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "C# 12 and .NET 8 – Modern Cross-Platform Development Fundamentals",
                    Edition = 8,
                    Author = "Mark J. Price",
                    PrintLenght = 828,
                    Language = "English",
                    Publisher = "Packt Publishing",
                    PublicationDate = new DateTime(2023,11,14)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Apps and Services with .NET 8: Build practical projects",
                    Edition = 2,
                    Author = "Mark J. Price",
                    PrintLenght = 798,
                    Language = "English",
                    Publisher = "Packt Publishing",
                    PublicationDate = new DateTime(2023,12,12)
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Clean Architecture: A Craftsman's Guide to Software Structure and Design",
                    Edition = 1,
                    Author = "Robert C. Martin",
                    PrintLenght = 432,
                    Language = "English",
                    Publisher = "Pearson",
                    PublicationDate = new DateTime(2017,9,10)
                }
            };

            return books;
        }
    }
}
