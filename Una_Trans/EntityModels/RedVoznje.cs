using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Una_Trans.Models
{
    public class RedVoznje
    {

        public int Id { get; set; }
        public string DatumPolaskaRedVoznje { get; set; }
        public string VrijemePolaskaRedVoznje { get; set; }
        public string VrijemeDolaskaRedVoznje { get; set; }
        public Grad Polaziste { get; set; }
        public int PolazisteId { get; set; }
        public Grad Odrediste { get; set; }
        public int OdredisteId { get; set; }
       
       
    }
}
