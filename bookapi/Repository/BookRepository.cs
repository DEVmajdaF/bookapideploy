using bookapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookapi.Repository
{
    public class BookRepository : IBook
    {


        private readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async  Task<string> GetBookbyId(int Id)
        {
            var name = await _context.Books.Where(c => c.Id == Id).Select(n => n.Title).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Book> GetBookDetails(int Id)
        {
            var emp = await _context.Books.FirstOrDefaultAsync(c => c.Id == Id);
            return emp;
        }




        //private readonly BookContext _context;
        //public BookRepository(BookContext context)
        //{
        //    _context= context;
        //}


        //public async  Task<List<Book>> Get()
        //{
        //    return await _context.Books.ToListAsync();

        //}

        //public async Task<Book> Get(int id)
        //{
        //    var s=  await _context.Books.FindAsync(id);
        //    return s;

        //}

        //public async  Task Update(Book book)
        //{
        //    _context.Entry(book).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //}
        //public async Task<Book> Create(Book book)
        //{
        //    await _context.Books.AddAsync(book);
        //    await _context.SaveChangesAsync();
        //    return book;
        //}

        //public async Task Delete(int id)
        //{
        //    var booktoget = await _context.Books.FindAsync(id);
        //    _context.Books.Remove(booktoget);
        //    await _context.SaveChangesAsync();
        //}

    }
}
