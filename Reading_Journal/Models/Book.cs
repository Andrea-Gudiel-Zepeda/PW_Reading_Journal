using System;
using System.Collections.Generic;

namespace Reading_Journal.Models;

public partial class Book
{
    public int IdBook { get; set; }

    public string NameBook { get; set; } = null!;

    public string AuthorBook { get; set; } = null!;

    public string YearBookPublish { get; set; } = null!;

    public DateTime? DateBook { get; set; }

    public int Calificacion { get; set; }

    public string PictureBook { get; set; } = null!;

    public int IdCategorie { get; set; }

    public int IdUser { get; set; }

    public virtual CategorieBook IdCategorieNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
