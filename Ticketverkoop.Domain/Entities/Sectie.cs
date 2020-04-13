using System;
using System.Collections.Generic;

namespace Ticketverkoop.Domain.Entities
{
    public partial class Sectie
    {
        public Sectie()
        {
            Zitje = new HashSet<Zitje>();
        }

        public int Id { get; set; }
        public string NaamSectie { get; set; }
        public int Idstadion { get; set; }
        public int? AantalPlaatsen { get; set; }
        public float? PrijsTicket { get; set; }
        public float? PrijsAbbonnement { get; set; }

        public virtual Stadion IdstadionNavigation { get; set; }
        public virtual ICollection<Zitje> Zitje { get; set; }
    }
}
