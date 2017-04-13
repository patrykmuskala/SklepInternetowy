using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamowienieId { get; set; }
        public int AlbumId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }
        public virtual Album Album { get; set; }
        public virtual Zamowienie zamowienie { get; set; }
    }
}