using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngSends
    {
        public EmailMngSends()
        {
            EmailMngSendAgain = new HashSet<EmailMngSendAgain>();
            EmailMngSendDocs = new HashSet<EmailMngSendDocs>();
            EmailMngSendFileAttachments = new HashSet<EmailMngSendFileAttachments>();
            EmailMngSendReceivers = new HashSet<EmailMngSendReceivers>();
            EmailMngSendStates = new HashSet<EmailMngSendStates>();
            EmailMngSendTrying = new HashSet<EmailMngSendTrying>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyEncoding { get; set; }
        public string BodyFormat { get; set; }
        public int From { get; set; }
        public string Priority { get; set; }
        public int RequesterUserId { get; set; }
        public int RequesterRoleId { get; set; }
        public DateTime RequestDate { get; set; }
        public int LastEditorUserId { get; set; }
        public int LastEditorRoleId { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string LastState { get; set; }
        public DateTime? LastChangeStateDate { get; set; }
        public int LastStateChangerUserId { get; set; }
        public int LastStateChangerRoleId { get; set; }
        public DateTime? LastTryDate { get; set; }
        public int LastTrierUserId { get; set; }
        public int LastTrierRoleId { get; set; }
        public string LastTryViewResult { get; set; }
        public string LastTryTechnicalResult { get; set; }
        public int TryCount { get; set; }
        public int SendCount { get; set; }
        public DateTime? LastSendAgainRequestDate { get; set; }
        public int LastSendAgainRequesterUserId { get; set; }
        public int LastSendAgainRequesterRoleId { get; set; }
        public int IndicatorId { get; set; }
        public bool? SecureSend { get; set; }
        public bool? Visible { get; set; }
        public string Crc { get; set; }

        public EmailMngMailBox FromNavigation { get; set; }
        public ICollection<EmailMngSendAgain> EmailMngSendAgain { get; set; }
        public ICollection<EmailMngSendDocs> EmailMngSendDocs { get; set; }
        public ICollection<EmailMngSendFileAttachments> EmailMngSendFileAttachments { get; set; }
        public ICollection<EmailMngSendReceivers> EmailMngSendReceivers { get; set; }
        public ICollection<EmailMngSendStates> EmailMngSendStates { get; set; }
        public ICollection<EmailMngSendTrying> EmailMngSendTrying { get; set; }
    }
}
