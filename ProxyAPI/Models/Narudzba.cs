using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            Korpas = new HashSet<Korpa>();
        }

        public int Idnarudzbe { get; set; }
        public int Idkorisnika { get; set; }
        public DateTime Vrijeme { get; set; }

        public virtual Korisnik IdkorisnikaNavigation { get; set; }
        public virtual ICollection<Korpa> Korpas { get; set; }
    }
}
