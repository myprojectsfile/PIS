using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SendDocAttachment
    {
        public int SendAttachCode { get; set; }
        public int SendCode { get; set; }
        public int? Etc { get; set; }
        public int? Ec { get; set; }
        public int EntityTypeCode { get; set; }
        public int EntityCode { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? CreationDate { get; set; }

        public Sends SendCodeNavigation { get; set; }
    }
}
