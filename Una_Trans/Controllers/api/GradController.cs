using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Una_Trans.EF;
using Una_Trans.Helper;
using Una_Trans.ViewModels.api;

namespace Una_Trans.Controllers.api
{
    public class GradController : MyWebApiBaseController
    {
        public GradController(MyContext db) : base(db)
        {
        }

        [HttpGet]
        public PregledGradovaVM GetAll()
        {
            return GetAll("");
        }

        [HttpGet("{parametar}")]
        public PregledGradovaVM GetAll(string parametar)
        {
            PregledGradovaVM pregledGradovaVM = new PregledGradovaVM();

            pregledGradovaVM.rows = _db.Grad.Where(x => x.Naziv.ToUpper().StartsWith(parametar.ToUpper())).
                Select(x => new PregledGradovaVM.Row
            {
                Id = x.Id,
                Naziv = x.Naziv
            }).ToList();


            return pregledGradovaVM;


        }
    }
}