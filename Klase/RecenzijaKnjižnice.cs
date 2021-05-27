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
        public string ImeKnjižnice { get; set; }
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
                                KnjižnicaID = r.LibraryUser.LibraryID,
                                ImeKnjižnice = r.LibraryUser.Library.Name,
                                KorisnickoIme = r.LibraryUser.Username,
                                //DatumUnosa = r.EntryDate
                            };
                korisnikoveRecenzije = query.ToList();
            }
            return korisnikoveRecenzije;
        }

        public static List<RecenzijaKnjižnice> DohvatiSveRecenzijeKnjiznice(int? knjiznicaID)
        {
            List<RecenzijaKnjižnice> sveRecenzije = new List<RecenzijaKnjižnice>();

            using (var context = new Entities())
            {
                var query = from r in context.ReviewLibraries
                            where r.LibraryUser.LibraryID == knjiznicaID
                            select new RecenzijaKnjižnice
                            {
                                RecenzijaID = r.ReviewLibraryID,
                                KorisnikID = r.UserID,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                KnjižnicaID = r.LibraryUser.LibraryID,
                                ImeKnjižnice = r.LibraryUser.Library.Name,
                                KorisnickoIme = r.LibraryUser.Username,
                                //DatumUnosa = r.EntryDate
                            };
                sveRecenzije = query.ToList();
            }
            return sveRecenzije;
        }
    }
}
