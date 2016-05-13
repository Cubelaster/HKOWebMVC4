using HKOWebMVC4.Models.HKOWebModels.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HKOWebMVC4.Models.HKOWebModels.Korisnik
{
    public class KorisnikOdabirZanimanja
    {
        public Dictionary<int, string> svaZanimanja { get; set; }
        public List<KorisnikOdabranaZanimanja> odabranaZanimanja { get; set; }

    }
}