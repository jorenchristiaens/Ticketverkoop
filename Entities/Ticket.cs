using System;
using System.Collections.Generic;

namespace Ticketverkoop_Beter.Entities
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public int IdZitje { get; set; }

        public virtual Zitje IdZitjeNavigation { get; set; }
    }
}
