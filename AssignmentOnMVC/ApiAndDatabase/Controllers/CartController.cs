using ApiAndDatabase.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAndDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly DBContextBooks _dBContextBooks;
        private readonly IMapper _mapper;

        public CartController(DBContextBooks dBContextBooks, IMapper mapper)
        {
            _dBContextBooks = dBContextBooks;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<Cart>> CartAdd(ModelApiCart modelApi)
        {
            var books = _mapper.Map<Cart>(modelApi);
            _dBContextBooks.Carts.Add(books);
            await _dBContextBooks.SaveChangesAsync();
            return Ok(_dBContextBooks.Carts);
        }
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            if (_dBContextBooks.Books == null)
            {
                return NoContent();
            }
            var book_details = await _dBContextBooks.Carts.ToListAsync();
            return Ok(book_details);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletebyId(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (_dBContextBooks.Carts == null)
            {
                return NoContent();
            }
            var book = await _dBContextBooks.Carts.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _dBContextBooks.Carts.Remove(book);
            await _dBContextBooks.SaveChangesAsync();
            return Ok(_dBContextBooks.Carts);
        }
    }
}
