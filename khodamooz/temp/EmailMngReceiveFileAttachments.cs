using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngReceiveFileAttachments
    {
        public int Id { get; set; }
        public int ReceiveId { get; set; }
        public string OriginalName { get; set; }
        public string Title { get; set; }
        public string PhysicalPath { get; set; }
        public int FileSize { get; set; }
        public DateTime FarzinReceiveDate { get; set; }
        public bool? FarzinReceiveCrcvalidation { get; set; }
        public string Crc { get; set; }

        public EmailMngReceives Receive { get; set; }
    }
}
