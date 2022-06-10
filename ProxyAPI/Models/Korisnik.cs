using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int Idkorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AdresaStanovanja { get; set; }
        public string KontaktTelefon { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}
