using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Una_Trans.ViewModels.api
{
    public class PregledLinijaVM
    {

        public class Rows
        {
            public int id;
            public string vrijemePolaska;
            public string vrijemeDolaska;
            public string datumDolaska;
            public string polaziste;
            public string odrediste;
           

        }

        public List<Rows> rows;
            
    }
}
