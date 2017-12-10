using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ShippingLine
    {
        public ShippingLine()
        {
            ReceiptCnt = new HashSet<ReceiptCnt>();
            SlotSharing = new HashSet<SlotSharing>();
        }

        public int LineId { get; set; }
        public string LineCode { get; set; }
        public string LineName { get; set; }
        public string CountryCode { get; set; }
        public short? ShippingId { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? Status { get; set; }
        public byte? LineType { get; set; }
        public bool? Coc { get; set; }

        public Shipping Shipping { get; set; }
        public ICollection<ReceiptCnt> ReceiptCnt { get; set; }
        public ICollection<SlotSharing> SlotSharing { get; set; }
    }
}
