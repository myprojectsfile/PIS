using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class UsersTickets
    {
        public int TicketCode { get; set; }
        public int UserCode { get; set; }
        public string Ticket { get; set; }
        public string SessionKey { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LastRequestDate { get; set; }
        public DateTime ClientTimeStamp { get; set; }
        public string Location { get; set; }
    }
}
