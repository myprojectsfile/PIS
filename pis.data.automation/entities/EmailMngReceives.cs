using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngReceives
    {
        public EmailMngReceives()
        {
            EmailMngFarzinReceivesInfo = new HashSet<EmailMngFarzinReceivesInfo>();
            EmailMngImportedReceiveList = new HashSet<EmailMngImportedReceiveList>();
            EmailMngReceiveFileAttachments = new HashSet<EmailMngReceiveFileAttachments>();
            EmailMngReceiveReceivers = new HashSet<EmailMngReceiveReceivers>();
        }

        public int Id { get; set; }
        public int MailBoxId { get; set; }
        public string MessageId { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string BodyHtml { get; set; }
        public string BodyCharset { get; set; }
        public string Priority { get; set; }
        public int AttachmentNo { get; set; }
        public long MessageSize { get; set; }
        public string SenderName { get; set; }
        public string SenderEmailAddress { get; set; }
        public DateTime Pop3ReceiveDate { get; set; }
        public DateTime FarzinReceiveDate { get; set; }
        public int ReceiverUserId { get; set; }
        public int ReceiverRoleId { get; set; }
        public bool? CompleteTransmission { get; set; }
        public bool? CompleteTransmissionRequest { get; set; }
        public bool? IsEceSend { get; set; }
        public bool? IsEceReceipt { get; set; }
        public string EceVersion { get; set; }
        public bool? SentByFarzin { get; set; }
        public bool? RemovedFromPop3 { get; set; }
        public DateTime? RemovedFromPop3Date { get; set; }
        public int RemoverFromPop3UserId { get; set; }
        public int RemoverFromPop3RoleId { get; set; }
        public string ReadStatus { get; set; }
        public DateTime? LastReadDate { get; set; }
        public int LastReaderUserId { get; set; }
        public int LastReaderRoleId { get; set; }
        public bool? Visible { get; set; }
        public string Crc { get; set; }
        public bool? IsSitad { get; set; }
        public bool? IsSitadReceipt { get; set; }

        public EmailMngMailBox MailBox { get; set; }
        public ICollection<EmailMngFarzinReceivesInfo> EmailMngFarzinReceivesInfo { get; set; }
        public ICollection<EmailMngImportedReceiveList> EmailMngImportedReceiveList { get; set; }
        public ICollection<EmailMngReceiveFileAttachments> EmailMngReceiveFileAttachments { get; set; }
        public ICollection<EmailMngReceiveReceivers> EmailMngReceiveReceivers { get; set; }
    }
}
