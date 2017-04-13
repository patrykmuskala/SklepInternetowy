using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz kategorię!")]
        [StringLength(50)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadz opis!")]
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }
        public virtual ICollection<Album> Albumy { get; set; }
    }
}