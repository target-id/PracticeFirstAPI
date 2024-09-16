using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Aplicacion.DTOs
{
    //Trae lo necesario para poder ingresar los parametros
    public class BooksDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int yearPublished { get; set; }
        public bool Available { get; set; }
    }
}
