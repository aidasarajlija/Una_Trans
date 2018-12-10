using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Una_Trans.EF;
using Una_Trans.Helper;
using Una_Trans.Models;
using Una_Trans.ViewModels.api;

namespace Una_Trans.Controllers.api
{
    public class ZakupAutobusaController : MyWebApiBaseController
    {
        public ZakupAutobusaController(MyContext db) : base(db)
        {
        }


        [HttpPost]
        public IActionResult AddZakupAutobusa([FromBody]ZakupAutobusaAddVM novi)
        {


            if (novi.adresaPolaska == "" || novi.brojPutnika == 0 || novi.datumDolaska == "" || novi.datumPolaska == "" ||
                novi.email=="" || novi.vrijemeDolaska=="" || novi.imePrezimeFirma=="" || novi.jMBG=="" ||
                novi.rutaPutovanja=="" || novi.vrijemePolaska=="" || novi.telefon=="" || novi.zakupGradId==0 || novi.zakupKorisnikId==0)
            {
                return StatusCode(500, "Sva polja su obavezna");
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(novi.email);

            if (!match.Success)
                return StatusCode(500, "Email nije validan");
            ZakupAutobusa zakup = new ZakupAutobusa()
            {
                ImePrezimeFirma = novi.imePrezimeFirma,
                JMBG = novi.jMBG,
                Telefon = novi.telefon,
                Email = novi.email,
                RutaPutovanja = novi.rutaPutovanja,
                BrojPutnika = novi.brojPutnika,
                AdresaPolaska = novi.adresaPolaska,
                DatumDolaska =novi.datumDolaska,
                DatumPolaska = novi.datumPolaska,
                VrijemeDolaska=novi.vrijemeDolaska,
                VrijemePolaska=novi.vrijemePolaska,
                ZakupGradId = novi.zakupGradId,
                KorisnikZakupId = novi.zakupKorisnikId

            };
            
            _db.Add(zakup);
            _db.SaveChanges();

            ZakupAutobusa k = _db.ZakupAutobusa.Where(x => x.Id == zakup.Id).SingleOrDefault();
            ZakupAutobusaAddVM noviZakup = new ZakupAutobusaAddVM();
            noviZakup.zakupKorisnikId = k.KorisnikZakupId;
            noviZakup.zakupGradId = k.ZakupGradId;
            noviZakup.vrijemePolaska = k.VrijemePolaska;
            noviZakup.vrijemeDolaska = k.VrijemeDolaska;
            noviZakup.telefon = k.Telefon;
            noviZakup.rutaPutovanja = novi.rutaPutovanja;
            noviZakup.jMBG = k.JMBG;
            noviZakup.imePrezimeFirma = k.ImePrezimeFirma;
            noviZakup.email = k.Email;
            noviZakup.datumPolaska = k.DatumPolaska;
            noviZakup.datumDolaska = k.DatumDolaska;
            noviZakup.brojPutnika = k.BrojPutnika;
            noviZakup.adresaPolaska = k.AdresaPolaska;
           




            return Ok(noviZakup);

        }

    }
}