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
        public string ImeZaposlenika { get; set; }
        public string PrezimeZaposlenika { get; set; }
        public RecenzijaZaposlenika()
            : base()
        {

        }

        public List<RecenzijaZaposlenika> DohvatiKorisnikoveRecenzijeKnjiznice(int korisnikID)
        {
            List<RecenzijaZaposlenika> korisnikoveRecenzije = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db())
            {
                var query = from r in context.ReviewEmployees
                            where r.UserID == korisnikID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate

                            };
                korisnikoveRecenzije = query.ToList();
            }
            List<RecenzijaZaposlenika> recenzijeSorted = korisnikoveRecenzije.OrderBy(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static List<RecenzijaZaposlenika> DohvatiSveRecenzijeZaposlenikaKnjiznice(int? knjiznicaID)
        {
            List<RecenzijaZaposlenika> sveRecenzije = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db())
            {
                var query = from r in context.ReviewEmployees
                            where r.LibraryUser1.LibraryID == knjiznicaID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate
                            };
                sveRecenzije = query.ToList();
            }  
            List<RecenzijaZaposlenika> recenzijeSorted = sveRecenzije.OrderBy(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static List<RecenzijaZaposlenika> DohvatiRecenzijeOdredenogZaposlenika(int? knjiznicaID, int zapolsenikID)
        {
            List<RecenzijaZaposlenika> recenzijeZaposlenika = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db())
            {
                var query = from r in context.ReviewEmployees
                            where r.LibraryUser1.LibraryID == knjiznicaID && r.EmployeeID == zapolsenikID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate
                            };
                recenzijeZaposlenika = query.ToList();
            }
            List<RecenzijaZaposlenika> recenzijeSorted = recenzijeZaposlenika.OrderBy(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }
    }
}

