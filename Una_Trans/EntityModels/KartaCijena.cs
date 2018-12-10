using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Una_Trans.Models;

namespace Una_Trans.EntityModels
{
    public class KartaCijena

    {
        public int Id { get; set; }
        public Karta CijenaKarta { get; set; }
        public int CijenaKartaId { get; set; }
        public RedVoznje CijenaRedVoznje { get; set; }
        public int CijenaRedVoznjeId { get; set; }
        public float Cijena { get; set; }

    }
}
