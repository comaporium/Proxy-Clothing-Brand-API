using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class VwStanjeArtikala
    {
        public int Idartikla { get; set; }
        public string Naziv { get; set; }
        public string Velicina { get; set; }
        public int Stanje { get; set; }
    }
}
