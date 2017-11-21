using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FaxMngSendReceivers
    {
        public int FaxId { get; set; }
        public int FaxServerId { get; set; }
        public string FaxServiceJobId { get; set; }
        public int? FaxPriority { get; set; }
        public string FaxNumber { get; set; }
        public int FaxType { get; set; }
        public int? FaxStatus { get; set; }
        public int? ExtendedFaxStatus { get; set; }
        public int? Etc { get; set; }
        public int? Ec { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public string SenderTitle { get; set; }
        public string SenderName { get; set; }
        public string Subject { get; set; }
        public DateTime? SendReceiveDate { get; set; }
        public int? Retries { get; set; }
        public string Message { get; set; }
        public bool? Isdelete { get; set; }
        public DateTime? ReadDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string MainEntityNumber { get; set; }
        public string MainImportEntityNumber { get; set; }
        public string MainExportEntityNumber { get; set; }
    }
}
