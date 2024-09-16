using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Dominio.Repositorio;
using Practica.Dominio.DataBase;

namespace Practica.Aplicacion.Servicios
{
    public class BookstoreServicios
    {
        private readonly IBookstoreRepositorio _repositorio;

        public BookstoreServicios(IBookstoreRepositorio repositorio) 
        {
            _repositorio = repositorio;
        }

        public async Task<IEnumerable<Book>> GetBookAsync() 
        {
            var resultado = _repositorio.GetBooksAsync();
            return await resultado;
        }

        public async Task<Book> GetBookById(int id) 
        {
            var resultado = _repositorio.GetBookById(id);
            return await resultado;
        }
        //Se agrega el metodo y se le envían los parametros
        public async Task<Book> CreateBook(int id, string title, string author, string genre, int yearPyblished, bool available) 
        {
            var resultado = _repositorio.CreateBook(id, title, author, genre, yearPyblished, available);
            return await resultado;
        }
    }
}
