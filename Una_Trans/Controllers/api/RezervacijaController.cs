using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Una_Trans.EF;
using Una_Trans.Helper;
using Una_Trans.Models;
using Una_Trans.ViewModels.api;

namespace Una_Trans.Controllers.api
{
    public class RezervacijaController : MyWebApiBaseController
    {
        public RezervacijaController(MyContext db) : base(db)
        {
        }

        [HttpGet("{polaziste}/{odrediste}/{datumPolaska}")]
        public PregledLinijaVM GetAll(int polaziste, int odrediste, string datumPolaska)
        {
            PregledLinijaVM pregledLinijaVM = new PregledLinijaVM();


            pregledLinijaVM.rows = _db.RedVoznje.
                Where(x=>x.OdredisteId==odrediste && x.PolazisteId==polaziste && x.DatumPolaskaRedVoznje == datumPolaska).Include(x=>x.Polaziste).Include(x=>x.Odrediste)
                .Select(x => new PregledLinijaVM.Rows
            {
                    id=x.Id,
                    vrijemeDolaska=x.VrijemeDolaskaRedVoznje,
                    vrijemePolaska=x.VrijemePolaskaRedVoznje,
                    datumDolaska=x.DatumPolaskaRedVoznje,
                    polaziste=x.Polaziste.Naziv,
                    odrediste=x.Odrediste.Naziv

            }).ToList();


            return pregledLinijaVM;
        }

        [HttpPost]
        public IActionResult Add([FromBody] RezervacijaAddVM nova)
        {

            Rezervacija rezervacija = new Rezervacija()
            {
                KartaCijenaId = nova.kartaCijenaId,
                KorisnikRezervacijaId=nova.korisnikRezervacijaId
            
            };
            _db.Add(rezervacija);
            _db.SaveChanges();



            Rezervacija k = _db.Rezervacija.Where(x => x.Id == rezervacija.Id).SingleOrDefault();
            RezervacijaAddVM novaRezervacija = new RezervacijaAddVM();
            novaRezervacija.kartaCijenaId = k.KartaCijenaId;
            novaRezervacija.korisnikRezervacijaId = k.KorisnikRezervacijaId;
           
            return Ok(novaRezervacija);
        }



    }
}