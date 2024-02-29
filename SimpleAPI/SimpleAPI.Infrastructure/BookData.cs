using SimpleAPI.Infrastructure.Context;
using SimpleAPI.Infrastructure.Interfaces;
using SimpleAPI.Models;

namespace SimpleAPI.Infrastructure
{
    /// <summary>
    /// Data Access Class of Book
    /// </summary>
    public class BookData : IBookData
    {
        private readonly AppDbContext _context;

        public BookData(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create a List of Books
        /// </summary>
        /// <param name="books"></param>
        public void Create(IEnumerable<Book> books)
        {
            _context.Book.AddRange(books);
            _context.SaveChanges();
        }

        /// <summary>
        /// Get a Book by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book? Get(Guid id)
        {
            return _context.Book.Where(b => b.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> Get()
        {
            return [.. _context.Book];
        }
    }
}
