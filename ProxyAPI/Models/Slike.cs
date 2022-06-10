using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Slike
    {
        public int Idslike { get; set; }
        public int Idartikla { get; set; }
        public string UrlSlike { get; set; }

        public virtual Artikli IdartiklaNavigation { get; set; }
    }
}
