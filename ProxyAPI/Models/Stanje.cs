using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Stanje
    {
        public int Idstanja { get; set; }
        public int Idartikla { get; set; }
        public int Idvelicine { get; set; }
        public int Stanje1 { get; set; }

        public virtual Artikli IdartiklaNavigation { get; set; }
        public virtual Velicine IdvelicineNavigation { get; set; }
    }
}
