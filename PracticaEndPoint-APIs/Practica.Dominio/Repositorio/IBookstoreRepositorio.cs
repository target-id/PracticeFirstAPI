using Practica.Dominio.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Dominio.Repositorio
{
    public interface IBookstoreRepositorio
    {
        public Task<IEnumerable<Book>> GetBooksAsync();
        public Task<Book> GetBookById(int id);
        public Task<Book> CreateBook(int id, string title, string author, string genre, int yearPyblished, bool available);
    }
}
