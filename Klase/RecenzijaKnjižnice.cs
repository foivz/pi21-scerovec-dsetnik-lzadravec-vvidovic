using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class RecenzijaKnjižnice : Recenzija
    {
        public int KnjižnicaID { get; set; }
        public RecenzijaKnjižnice()
            :base ()
        {
            
        }

        public List<RecenzijaKnjižnice> DohvatiKorisnikoveRecenzijeKnjiznice(int korisnikID) 
        {
            List<RecenzijaKnjižnice> korisnikoveRecenzije = new List<RecenzijaKnjižnice>();

            using (var context = new Entities()) 
            {
                var query = from r in context.ReviewLibraries
                            where r.UserID == korisnikID
                            select new RecenzijaKnjižnice 
                            { 
                                RecenzijaID = r.ReviewLibraryID,
                                KorisnikID = r.UserID,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                KnjižnicaID = r.LibraryUser.LibraryID
                            };
                korisnikoveRecenzije = query.ToList();
            }
            return korisnikoveRecenzije;
        }
    }
}
