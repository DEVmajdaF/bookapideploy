using bookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookapi.Repository
{
    public interface IBook
    {
        //Task<List<Book>> Get();
        //Task<Book> Get(int id);
        //Task<Book> Create(Book book);
        //Task Update(Book book);
        //Task Delete(int id);

        Task<string> GetBookbyId(int Id);
        Task<Book> GetBookDetails(int Id);
    }
}
