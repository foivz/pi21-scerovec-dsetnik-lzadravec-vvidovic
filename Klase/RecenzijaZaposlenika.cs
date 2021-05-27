using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    class RecenzijaZaposlenika : Recenzija
    {
        public int ZaposlenikID { get; set; }
        public RecenzijaZaposlenika()
            : base()
        {

        }

        public List<RecenzijaZaposlenika> DohvatiKorisnikoveRecenzijeKnjiznice(int korisnikID)
        {
            List<RecenzijaZaposlenika> korisnikoveRecenzije = new List<RecenzijaZaposlenika>();

            using (var context = new Entities())
            {
                var query = from r in context.ReviewEmployees
                            where r.UserID == korisnikID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                KorisnikID = r.UserID,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID
                            };
                korisnikoveRecenzije = query.ToList();
            }
            return korisnikoveRecenzije;
        }
    }
}

