using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe albumu!")]
        [StringLength(50)]
        public string TytulAlbumu { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe autora!")]
        [StringLength(50)]
        public string AutorAlbumu { get; set; }
        public DateTime DataDodania { get; set; }
        [StringLength(50)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisAlbumu { get; set; }
        public decimal CenaAlbumu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }
        public virtual Kategoria Kategoria { get; set; }
    }
}