using bitBooks_Project.Dorian_Iznimke;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public int TipID { get; set; }
        public string ImeTipa { get; set; }
        public int? KnjiznicaID { get; set; }
        public string ImeKnjiznice { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AktivacijskiKod { get; set; }
        public DateTime DatumRegistracije { get; set; }

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            List<Korisnik> sviKorisnici = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };

                sviKorisnici = query.ToList();
            }

            return sviKorisnici;
        }

        public static List<Korisnik> DohvatiKorisnikeKnjižnice(int? knjiznicaID)
        {
            List<Korisnik> korisniciKnjiznice = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciKnjiznice = query.ToList();
            }

            return korisniciKnjiznice;
        }

        public static List<Korisnik> DohvatiZaposlenikeKnjižnice(int? knjiznicaID)
        {
            List<Korisnik> zaposleniciKnjiznice = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.LibraryID == knjiznicaID && l.UserType.Name == "Zaposlenik"
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                zaposleniciKnjiznice = query.ToList();
            }

            return zaposleniciKnjiznice;
        }

        public static Korisnik DohvatiKorisnikaPoID(int korisnikID)
        {
            Korisnik korisnik;

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.UserID == korisnikID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisnik = query.Single();
            }

            return korisnik;
        }

        public string DohvatiTipKorisnika(Korisnik korisnik)
        {
            string tipKorisnika;
            using (var context = new Entities_db1())
            {
                var query = from u in context.UserTypes
                            where u.TypeID == korisnik.TipID
                            select u.Name;

                tipKorisnika = query.Single();
            }

            return tipKorisnika;
        }

        public static List<Korisnik> DohvatiKorisnikaPoImenu(string ime, int? knjiznicaID)
        {
            List<Korisnik> korisniciImena = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciImena = query.ToList();
            }

            return korisniciImena;
        }

        public static List<Korisnik> DohvatiKorisnikaPoPrezimenu(string prezime, int? knjiznicaID)
        {
            List<Korisnik> korisniciPrezimena = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Surname.Contains(prezime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciPrezimena = query.ToList();
            }

            return korisniciPrezimena;
        }

        public static List<Korisnik> DohvatiPoImenuIPrezimenu(string ime, string prezime, int? knjiznicaID)
        {
            List<Korisnik> korisniciImePrezime = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.Surname.Contains(prezime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciImePrezime = query.ToList();
            }

            return korisniciImePrezime;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public static Korisnik DohvatiKorisnikaPoKorisnickomImenu(string korime)
        {
            Korisnik korisnik = new Korisnik();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Username == korime
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisnik = query.ToList()[0];
            }

            return korisnik;
        }

        public static bool ProvjeriLozinku(string korime, string lozinka)
        {
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Username == korime
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                if (query.ToList()[0] != null)
                {
                    if (query.ToList()[0].Lozinka == lozinka)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Korisnik DohvatiKorisnikaPoEmailu(string email)
        {
            Korisnik korisnik;

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Email == email
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                try
                {
                    korisnik = query.First();
                }
                catch
                {
                    korisnik = null;
                }

            }

            return korisnik;
        }

        public static void ObrisiKorisnika(Korisnik korisnik)
        {
            ValidacijaBrisanja(korisnik);
            using (var context = new Entities_db1())
            {
                var query = (from l in context.LibraryUsers
                             where l.UserID == korisnik.KorisnikID
                             select l).FirstOrDefault();
                context.LibraryUsers.Remove(query);
                context.SaveChanges();

            }


        }

        private static void ValidacijaBrisanja(Korisnik korisnik)
        {
            if (korisnik.TipID == 1 || korisnik.TipID == 2)
            {
                throw new AdminException("Ne možete brisati admina iz baze!");
            }
        }

        public static int DohvatiBrojPosudbi(int korisnikID)
        {          
            List<Posudba> pos = new List<Posudba>();
            
            using (var context = new Entities_db1())
            {
                var query = from l in context.Loans
                            join u in context.LibraryUsers
                            on l.UserID equals u.UserID
                            where l.LoanStatus == "Posudena"
                            select new Posudba
                            {
                                PosudbaID = l.LoanID,
                                KorisnikID = l.UserID,
                                IzdanjeID = l.PublishingID,
                                DatumPovratka = l.DueDate,
                                StatusPosudbe = l.LoanStatus
                            };

                pos = query.ToList();
            }
            int i = 0;
            foreach(Posudba item in pos)
            {
                if (korisnikID == item.KorisnikID) i++;              
            }
            using (var context = new Entities_db1())
            {
                var query = from l in context.Loans
                            join u in context.LibraryUsers
                            on l.UserID equals u.UserID
                            where l.LoanStatus == "Zakasnjela"
                            select new Posudba
                            {
                                PosudbaID = l.LoanID,
                                KorisnikID = l.UserID,
                                IzdanjeID = l.PublishingID,
                                DatumPovratka = l.DueDate,
                                StatusPosudbe = l.LoanStatus
                            };

                pos = query.ToList();
            }           
            foreach (Posudba item in pos)
            {
                if (korisnikID == item.KorisnikID) i++;
            }

            return i;

        }
    }
}

