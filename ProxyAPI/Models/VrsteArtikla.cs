using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class VrsteArtikla
    {
        public VrsteArtikla()
        {
            Artiklis = new HashSet<Artikli>();
        }

        public int IdvrsteArtikla { get; set; }
        public string VrstaArtikla { get; set; }
        public string Parent { get; set; }

        public virtual ICollection<Artikli> Artiklis { get; set; }
    }
}
