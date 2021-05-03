using System;
using System.Collections.Generic;
using System.Text;

namespace kostroEugenFiltriranjeXML
{
    class Osoba
    {
        string Ime, Prezime, Email, Razred;

        public Osoba(string ime, string prezime, string email, string razred)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Razred = razred;
            this.Email = email;
        }

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Razred1 { get => Razred; set => Razred = value; }
    }
}
