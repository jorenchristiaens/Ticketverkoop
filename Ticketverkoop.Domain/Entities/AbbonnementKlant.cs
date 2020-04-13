using System;
using System.Collections.Generic;

namespace Ticketverkoop.Domain.Entities
{
    public partial class AbbonnementKlant
    {
        public int Id { get; set; }
        public int IdClub { get; set; }
        public DateTime? GeldigVan { get; set; }
        public int IdAbbonnement { get; set; }

        public virtual Abbonnementen IdAbbonnementNavigation { get; set; }
        public virtual Club IdClubNavigation { get; set; }
    }
}
