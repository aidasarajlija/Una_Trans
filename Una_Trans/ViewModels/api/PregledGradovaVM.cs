using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Una_Trans.ViewModels.api
{
    public class PregledGradovaVM
    {
        public class Row
        {
            public int Id;
            public string Naziv;
        }

        public List<Row> rows;
    }
}
