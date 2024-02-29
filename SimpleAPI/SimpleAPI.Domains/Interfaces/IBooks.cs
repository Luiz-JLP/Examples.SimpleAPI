using SimpleAPI.Models;

namespace SimpleAPI.Domains.Interfaces
{
    /// <summary>
    /// Book's Domains Interface
    /// </summary>
    public interface IBooks
    {
        /// <summary>
        /// Initialize a database
        /// </summary>
        /// <param name="books"></param>
        void InitializeDatabase(IEnumerable<Book> books);

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
