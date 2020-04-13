using System;
using System.Collections.Generic;

namespace Ticketverkoop.Domain.Entities
{
    public partial class Match
    {
        public Match()
        {
            Zitje = new HashSet<Zitje>();
        }

        public int Id { get; set; }
        public int IdStadion { get; set; }
        public int IdUitClub { get; set; }
        public DateTime? DatumMatch { get; set; }
        public DateTime? StartTijd { get; set; }
        public int? Seizoen { get; set; }

        public virtual Stadion IdStadionNavigation { get; set; }
        public virtual Club IdUitClubNavigation { get; set; }
        public virtual ICollection<Zitje> Zitje { get; set; }
    }
}
