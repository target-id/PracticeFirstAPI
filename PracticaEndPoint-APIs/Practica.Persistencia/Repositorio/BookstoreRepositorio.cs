using Microsoft.EntityFrameworkCore;
using Practica.Dominio.DataBase;
using Practica.Dominio.Repositorio;
using Practica.Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Persistencia.Repositorio
{
    public class BookstoreRepositorio : IBookstoreRepositorio
    {
        private readonly BookstoreDbContext _dbContext;
        public BookstoreRepositorio(BookstoreDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync() 
        {
            return await _dbContext.Books.ToListAsync();
        }

        //Este metodo devuelve un tipo de dato book pq pese a que le estamos pasando el id en int lo que tenemos que retornar es un libro
        public async Task<Book> GetBookById(int id) 
        {
            return await _dbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
        }

        public async Task<Book> CreateBook(int id, string title, string author, string genre, int yearPyblished, bool available) 
        {
            /*para poder crear un libro nuevo hay que tener en cuenta que el metodo add en el dbset no acepta muchos 
             argumentos en si, entonces hay que crear un objeto nuevo y guardar los parametros para poder realizarlo de manera correcta*/
            var newBook = new Book 
            {
                Id = id,
                Title = title,
                Author = author,
                Genre = genre,
                PublishedYear = yearPyblished,
                Available = available
            };

            _dbContext.Books.Add(newBook);
            return newBook;
        }
    }
}
