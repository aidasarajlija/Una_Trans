using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Una_Trans.EF;

namespace Una_Trans.Helper
{
    [Route("api/[controller]/[action]")]

    public abstract class MyWebApiBaseController : Controller
    {
        protected readonly MyContext _db;

        protected MyWebApiBaseController(MyContext db)
        {
            _db = db;
        }
    }
}