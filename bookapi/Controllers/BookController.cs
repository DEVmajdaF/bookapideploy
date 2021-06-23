using bookapi.Models;
using bookapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bookapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
         IBook _book;
        public BookController(IBook book)
        {
            _book = book;

        }

        [HttpGet(nameof(GetBookById))]
        public async Task<string> GetBookById(int Id)
        {
            var result = await _book.GetBookbyId(Id);
            return result;
        }
        [HttpGet(nameof(GetBookDetails))]
        public async Task<Book> GetBookDetails(int Id)
        {
            var result = await _book.GetBookDetails(Id);
            return result;
        }


        // GET: api/<BookController>
        //[HttpGet]
        //public async Task<IActionResult>  Get()
        //{
        //   var book = await _book.Get();
        //    return Ok(book);

        //}

        //// GET api/<BookController>/5
        //[HttpGet("{id}")]
        //public async  Task<IActionResult> Get(int id)
        //{
        //    var book2 = await _book.Get(id);
        //    return Ok(book2);
        //}

        //// POST api/<BookController>
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Book book)
        //{

        //    var NewBook = await _book.Create(book);
        //    return Ok(NewBook);

        //}

        //// PUT api/<BookController>/5
        //[HttpPut("{id}")]
        //public async Task<ActionResult> Put(int id, [FromBody] Book book)
        //{
        //    if(id != book.Id)
        //    {
        //        return BadRequest();
        //    }
        //    await _book.Update(book);
        //    return NoContent();
        //}

        //// DELETE api/<BookController>/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var bookToDelete = await _book.Get(id);
        //    if (bookToDelete == null)
        //        return NotFound();

        //    await _book.Delete(bookToDelete.Id);
        //    return NoContent();

        //}
    }
}
