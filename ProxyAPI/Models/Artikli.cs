using System;
using System.Collections.Generic;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class Artikli
    {
        public Artikli()
        {
            Korpas = new HashSet<Korpa>();
            Slikes = new HashSet<Slike>();
            Stanjes = new HashSet<Stanje>();
        }

        public int Idartikla { get; set; }
        public int IdvrsteArtikla { get; set; }
        public int Idnabavljaca { get; set; }
        public int Idboje { get; set; }
        public string Spol { get; set; }
        public string Cijena { get; set; }
        public string DodatneInformacije { get; set; }
        public DateTime? VrijemeDodavanja { get; set; }
        public string Naziv { get; set; }
        public int? GlavnaSlika { get; set; }

        public virtual Boje IdbojeNavigation { get; set; }
        public virtual Nabavljaci IdnabavljacaNavigation { get; set; }
        public virtual VrsteArtikla IdvrsteArtiklaNavigation { get; set; }
        public virtual ICollection<Korpa> Korpas { get; set; }
        public virtual ICollection<Slike> Slikes { get; set; }
        public virtual ICollection<Stanje> Stanjes { get; set; }
    }
}
