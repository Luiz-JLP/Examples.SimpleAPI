using SimpleAPI.Models;

namespace SimpleAPI.Domains.Interfaces
{
    /// <summary>
    /// Book's Domains Interface
    /// </summary>
    public interface IBooks
    {
        /// <summary>
        /// Get a Book by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Book Get(Guid id);

        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>
        IEnumerable<Book> Get();
    }
}
