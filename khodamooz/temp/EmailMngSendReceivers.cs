using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngSendReceivers
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public string EmailAddress { get; set; }
        public string ReceiveType { get; set; }
        public DateTime SpecifyDate { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public string Crc { get; set; }
        public int? ReceiverRoleId { get; set; }
        public string MoreInfo { get; set; }

        public EmailMngSends Send { get; set; }
    }
}
