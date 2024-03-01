using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SimpleAPI.Domains.Interfaces;
using System.Net;

namespace SimpleAPI.Application.Controllers
{
    /// <summary>
    /// Book's Controller
    /// </summary>
    [Controller]
    [Route("books")]
    public class BookController : Controller
    {
        private readonly IBooks _booksDomain;

        public BookController(IBooks domain)
        {
            _booksDomain = domain;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get(Guid id)
        {
            try
            {
                var book = _booksDomain.Get(id);
                return Ok(book);
            }
            catch (ArgumentException)
            {
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("all")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            try
            {
                var books = _booksDomain.Get();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
