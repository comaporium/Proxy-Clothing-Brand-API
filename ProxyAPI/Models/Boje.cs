using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Boje
    {
        public Boje()
        {
            Artiklis = new HashSet<Artikli>();
        }

        public int Idboje { get; set; }
        public string NazivBoje { get; set; }
        public string Sifra { get; set; }

        public virtual ICollection<Artikli> Artiklis { get; set; }
    }
}
