using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Velicine
    {
        public Velicine()
        {
            Stanjes = new HashSet<Stanje>();
        }

        public int Idvelicine { get; set; }
        public string Velicina { get; set; }

        public virtual ICollection<Stanje> Stanjes { get; set; }
    }
}
