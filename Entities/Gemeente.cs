using System;
using System.Collections.Generic;

namespace Ticketverkoop_Beter.Entities
{
    public partial class Gemeente
    {
        public Gemeente()
        {
            Stadion = new HashSet<Stadion>();
        }

        public int Id { get; set; }
        public string NaamGemeente { get; set; }
        public string Postcode { get; set; }

        public virtual ICollection<Stadion> Stadion { get; set; }
    }
}
