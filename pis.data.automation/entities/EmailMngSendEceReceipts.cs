using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngSendEceReceipts
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public int ImportEtc { get; set; }
        public int ImportEc { get; set; }
        public DateTime ImportDate { get; set; }
        public string ImportEntityNumber { get; set; }
        public bool? IsSitad { get; set; }
        public string SitadMessageId { get; set; }
        public string SitadReceiveMessageId { get; set; }
    }
}
