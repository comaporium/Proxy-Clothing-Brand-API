using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Korpa
    {
        public int Idkorpe { get; set; }
        public int Idnarudzbe { get; set; }
        public int Idartikla { get; set; }
        public int Komada { get; set; }
        public string Cijena { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Broj { get; set; }

        public virtual Artikli IdartiklaNavigation { get; set; }
        public virtual Narudzba IdnarudzbeNavigation { get; set; }
    }
}
