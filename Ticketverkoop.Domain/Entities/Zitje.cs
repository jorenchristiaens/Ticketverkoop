using System;
using System.Collections.Generic;

namespace Ticketverkoop.Domain.Entities
{
    public partial class Zitje
    {
        public Zitje()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public int IdSectie { get; set; }
        public int IdMatch { get; set; }

        public virtual Match IdMatchNavigation { get; set; }
        public virtual Sectie IdSectieNavigation { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
