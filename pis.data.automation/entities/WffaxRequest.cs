using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class WffaxRequest
    {
        public int RequestId { get; set; }
        public string FaxContent { get; set; }
        public string FaxNumber { get; set; }
        public string FaxReceiverName { get; set; }
        public string FaxSubject { get; set; }
        public string FaxDocumentName { get; set; }
        public int? UserId { get; set; }
        public string Status { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
