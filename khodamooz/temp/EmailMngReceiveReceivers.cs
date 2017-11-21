using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngReceiveReceivers
    {
        public int Id { get; set; }
        public int ReceiveId { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
        public string ReceiveType { get; set; }
        public DateTime FarzinReceiveDate { get; set; }

        public EmailMngReceives Receive { get; set; }
    }
}
