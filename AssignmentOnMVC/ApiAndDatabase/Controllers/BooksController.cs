using ApiAndDatabase.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAndDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController:Controller
    {
        private readonly DBContextBooks _dBContextBooks;
        private readonly IMapper _mapper;

        public BooksController(DBContextBooks dBContextBooks, IMapper mapper)
        {
           _dBContextBooks = dBContextBooks;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            if (_dBContextBooks.Books == null)
            {
                return NoContent();
            }
            var book_details = await _dBContextBooks.Books.ToListAsync();
            return Ok(book_details);
        }
        [HttpPost]
        public async Task<ActionResult<Books>> PostBooks(ModelApiBook modelApiBook)
        {
            var books=_mapper.Map<Books>(modelApiBook);
            _dBContextBooks.Books.Add(books);
           await _dBContextBooks.SaveChangesAsync();
            return Ok(_dBContextBooks.Books);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Books>> PutBooks(ModelApiBook modelApiBook,int id)
        {
            if (_dBContextBooks.Books == null)
            {
                return NoContent();
            }
            if (id == null)
            {
                return BadRequest();
            }
            var book=await _dBContextBooks.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            var books=_mapper.Map<Books>(modelApiBook);
            book.Id = id;
            book.Name=books.Name;
            book.Zoner=books.Zoner;
            book.Release_Date = books.Release_Date;
            book.Cost = books.Cost;
            book.Image=books.Image;
          //  _dBContextBooks.Entry(book).State = EntityState.Modified;
           _dBContextBooks.Books.Update(book);
            await _dBContextBooks.SaveChangesAsync();
            return Ok(_dBContextBooks.Books); 
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletebyId(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (_dBContextBooks.Books == null)
            {
                return NoContent();
            }
            var book= await _dBContextBooks.Books.FindAsync(id);
            if(book == null)
            {
                return NotFound();
            }
            _dBContextBooks.Books.Remove(book);
            await _dBContextBooks.SaveChangesAsync();
            return Ok(_dBContextBooks.Books);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetbyId(int id)
        {
            if (_dBContextBooks.Books == null)
            {
                return NoContent();
            }
            if (id == null)
            {
                return BadRequest();
            }
            var book =await _dBContextBooks.Books.FindAsync(id);
            return Ok(book);

        }
     
    }
}
