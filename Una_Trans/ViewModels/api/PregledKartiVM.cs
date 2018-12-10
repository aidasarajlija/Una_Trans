using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Una_Trans.ViewModels.api
{
    public class PregledKartiVM
    {
        public class Rows
        {
           public int id;
            public string naziv;
        }

        public List<Rows> rows;
    }
}
