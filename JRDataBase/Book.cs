using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRDataBase
{
    public class Book
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

    }
}
