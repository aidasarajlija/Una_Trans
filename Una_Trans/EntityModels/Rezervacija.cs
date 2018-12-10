using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Una_Trans.EntityModels;

namespace Una_Trans.Models
{
    public class Rezervacija
    {
        public int Id { get; set; }
       
        public KartaCijena KartaCijena { get; set; }
        public int KartaCijenaId { get; set; }

        public Korisnik KorisnikRezervacija { get; set; }
        public int KorisnikRezervacijaId { get; set; }
    }
}
