using System;
using System.Collections.Generic;

namespace Ticketverkoop_Beter.Entities
{
    public partial class Abbonnementen
    {
        public Abbonnementen()
        {
            AbbonnementKlant = new HashSet<AbbonnementKlant>();
        }

        public int Id { get; set; }
        public string NaamAbbonnement { get; set; }
        public int? GeldijgheidTermijn { get; set; }
        public string Voorwaarden { get; set; }

        public virtual ICollection<AbbonnementKlant> AbbonnementKlant { get; set; }
    }
}
