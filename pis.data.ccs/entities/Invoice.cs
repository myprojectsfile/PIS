using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Invoice
    {
        public long InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public long? VoyageId { get; set; }
        public string AdministrationBlNumber { get; set; }
        public string Blid { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string CallSign { get; set; }
        public decimal? Weight { get; set; }
        public long? PersonId { get; set; }
        public decimal? CustomsValue { get; set; }
        public decimal? AssuranceRating { get; set; }
        public DateTime? InvoiceBaseTime { get; set; }
        public int? Count20 { get; set; }
        public int? Count40 { get; set; }
        public int? InvoiceStorageTime { get; set; }
        public int? StripCount20 { get; set; }
        public int? StripCount40 { get; set; }
        public int? NonstandardCount { get; set; }
        public int? DangerousCount { get; set; }
        public int? Cif { get; set; }
        public decimal? StoragePrice { get; set; }
        public decimal? CfsStoragePrice { get; set; }
        public decimal? MovePrice { get; set; }
        public decimal? StripPrice { get; set; }
        public decimal? StuffingPrice { get; set; }
        public decimal? ReeferMonitoringPrice { get; set; }
        public decimal? SealPrice { get; set; }
        public decimal? ElectronicServices { get; set; }
        public decimal? PowerService { get; set; }
        public decimal? MovePriceMore { get; set; }
        public decimal? DischargePrice { get; set; }
        public decimal? FreightDischargDeliveryePrice { get; set; }
        public decimal? PortDuty { get; set; }
        public decimal? Demand { get; set; }
        public decimal? WorkHealth { get; set; }
        public decimal? LocalAssurance { get; set; }
        public decimal? SpecialZoneService { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Duty { get; set; }
        public decimal? OrganizationPrice { get; set; }
        public decimal? PortPrice { get; set; }
        public decimal? GrandTotal { get; set; }
        public string IssuedComplementInvoices { get; set; }
        public string Description { get; set; }
        public decimal? PmCost { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? Status { get; set; }
        public long? ParentInvoiceId { get; set; }
        public long? InvoiceMasterId { get; set; }
    }
}
