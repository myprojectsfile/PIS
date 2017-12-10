using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceReceiptContainer
    {
        public long InvoiceReceiptContainerId { get; set; }
        public long? ContainerId { get; set; }
        public long? Blid { get; set; }
        public long? InvoiceReceiptId { get; set; }
        public DateTime? DischargeDate { get; set; }
        public decimal? StripContent { get; set; }
        public bool? StripType { get; set; }
        public decimal? HeavilyPrice { get; set; }
        public int? MoveCount { get; set; }
        public int? SealCount { get; set; }
        public int? ReeferCount { get; set; }
        public int? AutomobileCount { get; set; }
        public int? AutomobileRestrainCount { get; set; }
        public int? WagonStrip { get; set; }
        public int? CfsStorageTime { get; set; }
        public decimal? CfsStorageWeight { get; set; }
        public int? StorageTime { get; set; }
        public int? SecondExportImmunity { get; set; }
        public decimal? PercentShareCommon { get; set; }
        public bool? IsFreightDeliveryCosts { get; set; }
        public decimal? FreightDeliveryCosts { get; set; }
    }
}
