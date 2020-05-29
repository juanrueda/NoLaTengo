using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoLaTengo.Dtos;
using NoLaTengo.Services;

namespace NoLaTengo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController (IBookService bookService){
            _bookService = bookService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllBooks() 
        {
            return Ok(await _bookService.GetAllBooks());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            return Ok(await _bookService.GetBookById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookDto newBook)
        {
            return Ok(await _bookService.AddBook(newBook));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            return Ok(await _bookService.DeleteBook(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookDto updatedBook)
        {
            return Ok(await _bookService.UpdateBook(updatedBook));
        }



}
}