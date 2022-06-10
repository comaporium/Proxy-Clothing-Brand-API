using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class VwZadnjiPetAccesory
    {
        public int Idartikla { get; set; }
        public string Naziv { get; set; }
        public string NazivNabavljaca { get; set; }
        public string Spol { get; set; }
        public string Cijena { get; set; }
        public string DodatneInformacije { get; set; }
        public string VrstaArtikla { get; set; }
        public string Parent { get; set; }
        public string UrlSlike { get; set; }
    }
}
