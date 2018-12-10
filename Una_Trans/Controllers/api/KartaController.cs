using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Una_Trans.EF;
using Una_Trans.EntityModels;
using Una_Trans.Helper;
using Una_Trans.ViewModels.api;

namespace Una_Trans.Controllers.api
{
    public class KartaController : MyWebApiBaseController
    {
        public KartaController(MyContext db) : base(db)
        {
        }

        public PregledKartiVM GetAll()
        {
            PregledKartiVM pregledKartiVM = new PregledKartiVM();

            pregledKartiVM.rows = _db.Karta.Select(x => new PregledKartiVM.Rows
            {
                id=x.Id,
                naziv=x.Naziv
            }).ToList();

            return pregledKartiVM;
        }



        [HttpGet("{redId}/{kartaId}")]
        public PregledCijenaKartaVM GetCijenaKarte(int redId, int kartaId)
        {
            PregledCijenaKartaVM Model = new PregledCijenaKartaVM();

            KartaCijena kartaCijena = _db.KartaCijena.Where(x => x.CijenaKartaId == kartaId && x.CijenaRedVoznjeId == redId).SingleOrDefault();
            Model.cijena = kartaCijena.Cijena;
            Model.redId = kartaCijena.CijenaRedVoznjeId;
            Model.kartaID = kartaCijena.CijenaKartaId;
            Model.id = kartaCijena.Id;
            return Model;
        }
    }

   
}