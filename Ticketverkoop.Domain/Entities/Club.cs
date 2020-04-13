using System;
using System.Collections.Generic;

namespace Ticketverkoop.Domain.Entities
{
    public partial class Club
    {
        public Club()
        {
            AbbonnementKlant = new HashSet<AbbonnementKlant>();
            Match = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string NaamClub { get; set; }
        public int IdThuisstadion { get; set; }
        public string Logo { get; set; }

        public virtual Stadion IdThuisstadionNavigation { get; set; }
        public virtual ICollection<AbbonnementKlant> AbbonnementKlant { get; set; }
        public virtual ICollection<Match> Match { get; set; }
    }
}
