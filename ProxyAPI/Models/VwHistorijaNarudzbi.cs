using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class VwHistorijaNarudzbi
    {
        public int Idnarudzbe { get; set; }
        public int Idkorisnika { get; set; }
        public string Username { get; set; }
        public int Idartikla { get; set; }
        public string Naziv { get; set; }
        public int Komada { get; set; }
        public string Cijena { get; set; }
        public DateTime Vrijeme { get; set; }
    }
}
