using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Una_Trans.EntityModels
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
       public string email { get; set; }
        public string lozinka { get; set; }
    }
}
