using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Una_Trans.EntityModels;

namespace Una_Trans.Models
{
    public class ZakupAutobusa
    {
        public int Id { get; set; }


        public Grad ZakupGrad { get; set; }
        public int ZakupGradId { get; set; }

        public string ImePrezimeFirma { get; set; }
        public string JMBG { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string RutaPutovanja { get; set; }
        public int BrojPutnika { get; set; }
        public string AdresaPolaska { get; set; }
        public string DatumPolaska { get; set; }
        public string DatumDolaska { get; set; }
        public string VrijemePolaska { get; set; }
        public string VrijemeDolaska { get; set; }

        public Korisnik KorisnikZakup { get; set; }
        public int KorisnikZakupId { get; set; }


    }
}
