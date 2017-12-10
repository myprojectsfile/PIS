using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ExportReceipt
    {
        public long ReceiptId { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime IssuanceDate { get; set; }
        public long CustomId { get; set; }
        public string DischargePermissionNumber { get; set; }
        public string SourceCustoms { get; set; }
        public string ExitCustoms { get; set; }
        public string SealNumber { get; set; }
        public decimal? ScaleWeight { get; set; }
        public decimal? DeclareWeight { get; set; }
        public bool? Cancel { get; set; }
        public long? PersonId { get; set; }
        public int? EntryType { get; set; }
        public string IssuedBy { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public string ConfirmBy { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public bool? FinalConfirm { get; set; }
        public bool? Reckoned { get; set; }

        public Cargo Custom { get; set; }
    }
}
