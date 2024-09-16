using System;
using System.Collections.Generic;

namespace Practica.Dominio.DataBase;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string? Genre { get; set; }

    public int? PublishedYear { get; set; }

    public bool? Available { get; set; }
}
