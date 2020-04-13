using System;
using System.Collections.Generic;

namespace Ticketverkoop.Domain.Entities
{
    public partial class Stadion
    {
        public Stadion()
        {
            Club = new HashSet<Club>();
            Match = new HashSet<Match>();
            Sectie = new HashSet<Sectie>();
        }

        public int Id { get; set; }
        public int IdGemeente { get; set; }
        public string Straat { get; set; }
        public int? HuisNr { get; set; }
        public string NaamStadion { get; set; }

        public virtual Gemeente IdGemeenteNavigation { get; set; }
        public virtual ICollection<Club> Club { get; set; }
        public virtual ICollection<Match> Match { get; set; }
        public virtual ICollection<Sectie> Sectie { get; set; }
    }
}
