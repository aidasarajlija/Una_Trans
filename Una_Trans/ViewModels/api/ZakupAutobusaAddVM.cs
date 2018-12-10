using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Una_Trans.Models;

namespace Una_Trans.ViewModels.api
{
    public class ZakupAutobusaAddVM
    {
        public int zakupGradId;
        public int zakupKorisnikId;

        public String imePrezimeFirma;
        public String jMBG;
        public String telefon;
        public String email;
        public String rutaPutovanja;
        public int brojPutnika;
        public String adresaPolaska;
        public String datumPolaska;
        public String datumDolaska;
        public String vrijemePolaska;
        public String vrijemeDolaska;
    }
}
