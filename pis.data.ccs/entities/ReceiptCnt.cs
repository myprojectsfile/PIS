using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ReceiptCnt
    {
        public long Id { get; set; }
        public long? ContainerId { get; set; }
        public DateTime? DischargeDate { get; set; }
        public long? VoyageId { get; set; }
        public DateTime? Date { get; set; }
        public int? LineId { get; set; }
        public string OfficeNo { get; set; }
        public string ReceiptNo { get; set; }
        public int? UserId { get; set; }

        public ShippingLine Line { get; set; }
        public User User { get; set; }
        public Voyage Voyage { get; set; }
    }
}
