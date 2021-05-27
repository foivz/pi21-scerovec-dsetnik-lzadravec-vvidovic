using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Knjižnica
    {
        public int KnjižnicaID { get; set; }
        public int? Admin { get; set; }
        public string Ime { get; set; }

        public List<Knjižnica> DohvatiSveKnjiznice() 
        {
            List<Knjižnica> sveKnjiznice = new List<Knjižnica>();

            using (var context = new Entities()) 
            {
                var query = from l in context.Libraries
                            select new Knjižnica 
                            {
                                KnjižnicaID = l.LibraryID,
                                Admin = l.Administrator,
                                Ime = l.Name
                            };
                sveKnjiznice = query.ToList();
            }

            return sveKnjiznice;
        }
    }
}
