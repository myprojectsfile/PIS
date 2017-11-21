using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngSendFileAttachments
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public string Title { get; set; }
        public string PhysicalPath { get; set; }
        public int EntityTypeCode { get; set; }
        public int EntityCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public string Crc { get; set; }

        public EmailMngSends Send { get; set; }
    }
}
