using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Una_Trans.EF;
using Una_Trans.EntityModels;
using Una_Trans.Helper;
using Una_Trans.ViewModels.api;

namespace Una_Trans.Controllers
{
    public class LoginController : MyWebApiBaseController
    {
        public LoginController(MyContext db) : base(db)
        {
        }

        [HttpGet("{e}/{l}")]
        public PregledLogiranogKorisnikaVM GetKorisnika(string e, string l)
        {
            PregledLogiranogKorisnikaVM novi = new PregledLogiranogKorisnikaVM();
            Korisnik korisnik = _db.Korisnik.Where(x => x.email == e && x.lozinka == l).SingleOrDefault();
               
            if (korisnik != null)
            {
                novi.id = korisnik.Id;
                novi.ime = korisnik.Ime;
                novi.prezime = korisnik.Prezime;
                novi.email = korisnik.email;
                novi.lozinka = korisnik.lozinka;

            }

            return novi;

           
        }


        [HttpPost]
        public IActionResult Add([FromBody] PregledLogiranogKorisnikaVM novi)
        {

            if (novi.ime == "" || novi.prezime=="" || novi.email == "" || novi.lozinka == "")
            {
                return StatusCode(500, "Sva polja su obavezna");
            }

            if (novi.lozinka.Length<8)
            {
                return StatusCode(500, "Lozinka mora sadržavati minimalno 8 karaktera");
            }

            Korisnik k1 = _db.Korisnik.Where(x => x.email == novi.email).SingleOrDefault();

            if (k1 != null)
            {
                return StatusCode(500, "Email adresa je iskorišena");
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(novi.email);

            if (!match.Success)
                return StatusCode(500, "Email nije validan");



            Korisnik korisnik = new Korisnik
            {
                Ime = novi.ime,
                Prezime = novi.prezime,
                email = novi.email,
                lozinka = novi.lozinka


            };

            _db.Add(korisnik);
            _db.SaveChanges();


            Korisnik k = _db.Korisnik.Where(x => x.Id == korisnik.Id).SingleOrDefault();
            PregledLogiranogKorisnikaVM noviKorisnik = new PregledLogiranogKorisnikaVM();
            noviKorisnik.id = k.Id;
            noviKorisnik.ime = k.Ime;
            noviKorisnik.prezime = k.Prezime;
            noviKorisnik.email = k.email;
            noviKorisnik.lozinka = k.lozinka;


            return Ok(noviKorisnik);

        }
    }
}