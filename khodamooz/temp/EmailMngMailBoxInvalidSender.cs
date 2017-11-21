using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngMailBoxInvalidSender
    {
        public int Id { get; set; }
        public int MailBoxId { get; set; }
        public string EmailAddress { get; set; }
        public bool? Active { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public int? LastEditorUserId { get; set; }
        public int? LastEditorRoleId { get; set; }
        public string Crc { get; set; }

        public EmailMngMailBox MailBox { get; set; }
    }
}
