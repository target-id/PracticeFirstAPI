using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Practica.Aplicacion.DTOs;
using Practica.Aplicacion.Servicios;
using Practica.Dominio.DataBase;
using Practica.Dominio.Repositorio;

namespace PracticaEndPoint_APIs.Controllers
{
    [ApiController]
    [Route("Practica/[controller]")]
    public class BookstoreController : ControllerBase
    {
        private readonly BookstoreServicios _servicios;
        public BookstoreController(BookstoreServicios bookstoreServicio)
        {
            _servicios = bookstoreServicio;
        }

        [HttpGet("Todos-los-libros")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _servicios.GetBookAsync();
            return Ok(books);
        }

        [HttpGet("Filtrar-por-id")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var books = await _servicios.GetBookById(id);
            if (books != null)
            {
                return Ok(books);
            }
            else
            {
                return NotFound($"No se encontró un libro con el id: {id}");
            }
        }

        [HttpPost("Crear-libro")]//Para ingresar un nuevo dato a la tabla
        //Se usa frombody para enviar los datos relevantes de la accion a la solicitud, generalmente se hace en formato JSON
        public async Task<IActionResult> CreateBook([FromBody] BooksDTO b) 
        {
            //se llama al metodo de crear un libro y se le pasan las propiedades del DTO con las que va a trabajar y eso se guarda en una variable
            var newBook = await _servicios.CreateBook(b.Id,b.Title,b.Author,b.Genre,b.yearPublished,b.Available);

            /*Crea una accion en exitosa en el servidor. El nameof basicamente significa que cuando se cree la accion 
             me va a devolver los datos del libro recien creado. Por último se crea un objeto anonimo que va a entregar el id recien creado
            al metodo de getbookbyid*/
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);//Se devuelve el nuevo objeto recien creado
        }
       
    }
}
