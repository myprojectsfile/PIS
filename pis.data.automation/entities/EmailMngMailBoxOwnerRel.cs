using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngMailBoxOwnerRel
    {
        public int Id { get; set; }
        public int MailBoxOwnerId { get; set; }
        public int MailBoxId { get; set; }
        public bool? Active { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public int? LastEditorUserId { get; set; }
        public int? LastEditorRoleId { get; set; }
        public string Crc { get; set; }

        public EmailMngMailBox MailBox { get; set; }
        public EmailMngMailBoxOwner MailBoxOwner { get; set; }
    }
}
