using SimpleAPI.Models;

namespace SimpleAPI.Infrastructure.Interfaces
{
    /// <summary>
    /// Data Access Interface of Book
    /// </summary>
    public interface IBookData
    {
        /// <summary>
        /// Create a List of Books
        /// </summary>
        /// <param name="books"></param>
        void Create(IEnumerable<Book> books);

        /// <summary>
        /// Get a Book by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Book? Get(Guid id);

        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>
        IEnumerable<Book> Get();
    }
}
