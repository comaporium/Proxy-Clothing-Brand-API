using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Nabavljaci
    {
        public Nabavljaci()
        {
            Artiklis = new HashSet<Artikli>();
        }

        public int Idnabavljaca { get; set; }
        public string NazivNabavljaca { get; set; }
        public string Broj { get; set; }

        public virtual ICollection<Artikli> Artiklis { get; set; }
    }
}
