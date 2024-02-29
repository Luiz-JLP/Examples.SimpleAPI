namespace SimpleAPI.Models.Base
{
    /// <summary>
    /// Abstract Class for any Models
    /// </summary>
    public abstract class Model
    {
        /// <summary>
        /// Unique Identifier
        /// </summary>
        public Guid Id { get; set; }
    }
}
