using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SendFileAttachment
    {
        public int SendAttachCode { get; set; }
        public int SendCode { get; set; }
        public int? Etc { get; set; }
        public int? Ec { get; set; }
        public string FilePath { get; set; }
        public string OriginalFileName { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? CreationDate { get; set; }

        public Sends SendCodeNavigation { get; set; }
    }
}
