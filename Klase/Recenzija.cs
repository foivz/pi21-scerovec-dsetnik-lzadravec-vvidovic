using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public abstract class Recenzija
    {
        public int RecenzijaID { get; set; }
        public int KorisnikID { get; set; }
        public string TekstRecenzije { get; set; }
        public int Ocjena { get; set; }

    }
}
