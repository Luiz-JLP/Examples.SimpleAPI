using SimpleAPI.Models.Base;

namespace SimpleAPI.Models
{
    /// <summary>
    /// Book's Model
    /// </summary>
    public class Book : Model
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Edition
        /// </summary>
        public int Edition { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; } = string.Empty;

        /// <summary>
        /// PrintLenght
        /// </summary>
        public int PrintLenght { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        public string Language {  get; set; } = string.Empty;

        /// <summary>
        /// Publisher
        /// </summary>
        public string Publisher { get; set; } = string.Empty;

        /// <summary>
        /// PublicationDate
        /// </summary>
        public DateTime PublicationDate { get; set; }
    }
}
