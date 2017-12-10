using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceMaster
    {
        public InvoiceMaster()
        {
            InvoiceDetail = new HashSet<InvoiceDetail>();
        }

        public long InvoiceMasterId { get; set; }
        public long? VesselId { get; set; }
        public long? VoyageId { get; set; }
        public long? Blid { get; set; }
        public DateTime? DischargeDate { get; set; }
        public DateTime? InvoiceTime { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? BlWeight { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal? DischargePrice { get; set; }
        public decimal? PortDuty { get; set; }
        public decimal? WorkHealth { get; set; }
        public decimal? LocalAssurance { get; set; }
        public int? NumberOfSeal { get; set; }
        public decimal? Demand { get; set; }
        public decimal? ElectronicServices { get; set; }
        public decimal? StuffingPrice { get; set; }
        public DateTime? InvoiceBaseTime { get; set; }
        public string AdministrationBlNumber { get; set; }
        public decimal? CustomsValue { get; set; }
        public decimal? AssuranceRating { get; set; }
        public decimal? AssuranceExemption { get; set; }
        public string IssuedComplementInvoices { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
