using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Certificates
    {
        public int CertificateId { get; set; }
        public int OwnerId { get; set; }
        public int? CarootId { get; set; }
        public string ViewName { get; set; }
        public string SerialNumber { get; set; }
        public string FingerPrint { get; set; }
        public string Certificate { get; set; }
        public DateTime? RevokeDate { get; set; }
        public string RevocationReasonCode { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? SuspendByAdmin { get; set; }
        public int CreateRoleId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
