using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngMailBox
    {
        public EmailMngMailBox()
        {
            EmailMngMailBoxInvalidSender = new HashSet<EmailMngMailBoxInvalidSender>();
            EmailMngMailBoxOwnerRel = new HashSet<EmailMngMailBoxOwnerRel>();
            EmailMngMailBoxReceiveTrying = new HashSet<EmailMngMailBoxReceiveTrying>();
            EmailMngReceives = new HashSet<EmailMngReceives>();
            EmailMngSends = new HashSet<EmailMngSends>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
        public bool? ForSend { get; set; }
        public bool? AutomaticSend { get; set; }
        public bool? ForReceive { get; set; }
        public bool? AutomaticReceive { get; set; }
        public int? Pop3Id { get; set; }
        public string Pop3UserName { get; set; }
        public string Pop3Password { get; set; }
        public bool? AttachmentsTransmission { get; set; }
        public bool? DeleteFromPop3 { get; set; }
        public int? SmtpId { get; set; }
        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
        public bool? Active { get; set; }
        public string Desc { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public int? LastEditorUserId { get; set; }
        public int? LastEditorRoleId { get; set; }
        public string Crc { get; set; }

        public EmailMngPop3 Pop3 { get; set; }
        public ICollection<EmailMngMailBoxInvalidSender> EmailMngMailBoxInvalidSender { get; set; }
        public ICollection<EmailMngMailBoxOwnerRel> EmailMngMailBoxOwnerRel { get; set; }
        public ICollection<EmailMngMailBoxReceiveTrying> EmailMngMailBoxReceiveTrying { get; set; }
        public ICollection<EmailMngReceives> EmailMngReceives { get; set; }
        public ICollection<EmailMngSends> EmailMngSends { get; set; }
    }
}
