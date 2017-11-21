using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngSendDocs
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public bool? IsEce { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string ExportEntityNumber { get; set; }
        public DateTime ExportDate { get; set; }
        public bool? IsSitad { get; set; }
        public string SitadMessageId { get; set; }
        public string SitadReceiveMessageId { get; set; }

        public EmailMngSends Send { get; set; }
    }
}
