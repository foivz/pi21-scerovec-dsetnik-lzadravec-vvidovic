﻿using System;
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
        public int? KnjiznicaID { get; set; }
        public string Email { get; set; }
        public string  Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AktivacijskiKod { get; set; }
        public DateTime DatumRegistracije { get; set; }

        public  static List<Korisnik> DohvatiSveKorisnike()
        {
            List<Korisnik> sviKorisnici = new List<Korisnik>();

            using (var context = new Entities())
            {
                var query = from l in context.LibraryUsers
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                KnjiznicaID = l.LibraryID,
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

            using (var context = new Entities()) 
            {
                var query = from l in context.LibraryUsers
                            where l.LibraryID == knjiznicaID
                            select new Korisnik 
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                KnjiznicaID = l.LibraryID,
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

        public Korisnik DohvatiKorisnikaPoID(int korisnikID)
        {
            Korisnik korisnik;

            using (var context = new Entities())
            {
                var query = from l in context.LibraryUsers
                            where l.UserID == korisnikID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                KnjiznicaID = l.LibraryID,
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
            using (var context = new Entities())
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
            using (var context = new Entities())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                KnjiznicaID = l.LibraryID,
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
            using (var context = new Entities())
            {
                var query = from l in context.LibraryUsers
                            where l.Surname.Contains(prezime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                KnjiznicaID = l.LibraryID,
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
            using (var context = new Entities())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.Surname.Contains(prezime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                KnjiznicaID = l.LibraryID,
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
    }
}
