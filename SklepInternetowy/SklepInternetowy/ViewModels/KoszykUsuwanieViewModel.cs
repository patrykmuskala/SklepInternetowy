using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Views
{
    public class KoszykUsuwanieViewModel
    {
        public decimal KoszykCenaCalkowita { get; set; }
        public int KoszykIloscPozycji { get; set; }
        public int IloscPozycjiUsuwanych { get; set; }
        public int IdPozycjiUsuwanej { get; set; }
    }
}