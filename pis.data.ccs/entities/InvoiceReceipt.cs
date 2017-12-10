using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceReceipt
    {
        public long InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public short? OperatorId { get; set; }
        public long? Blid { get; set; }
        public DateTime? DischargeDate { get; set; }
        public decimal? DischargePrice { get; set; }
        public decimal? PortDuty { get; set; }
        public decimal? Demand { get; set; }
        public decimal? WorkHealth { get; set; }
        public decimal? LocalAssurance { get; set; }
        public int? Count20F { get; set; }
        public int? Count40F { get; set; }
        public int? StorageTime { get; set; }
        public decimal? StoragePrice { get; set; }
        public decimal? StripPrice { get; set; }
        public int? StripCount { get; set; }
        public decimal? MovePrice { get; set; }
        public int? MoveCount { get; set; }
        public decimal? SealPrice { get; set; }
        public int? SealCount { get; set; }
        public decimal? ReeferPrice { get; set; }
        public int? ReeferCount { get; set; }
        public decimal? AutomobilePrice { get; set; }
        public int? AutomobileCount { get; set; }
        public decimal? AutomobileRestrainPrice { get; set; }
        public int? AutomobileRestrainCount { get; set; }
        public int? CfsStorageTime { get; set; }
        public decimal? CfsStoragePrice { get; set; }
        public decimal? ElectornicServicesPrice { get; set; }
        public decimal? CustomsValue { get; set; }
        public decimal? InsuranceRate { get; set; }
        public decimal? InsuranceExemption { get; set; }
        public decimal? GrossAmountBill { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? TotalGrossAmountBill { get; set; }
        public decimal? StuffingPrice { get; set; }
        public decimal? InvoiceTax { get; set; }
        public decimal? InvoiceDuty { get; set; }
        public decimal? FreightDeliveryCosts { get; set; }
        public long? ReceiptId { get; set; }
        public decimal? PortShare { get; set; }
        public decimal? OperatorShare { get; set; }
        public DateTime? InvoiceBaseDate { get; set; }
        public decimal? ExtraPortTaxDuty { get; set; }
    }
}
