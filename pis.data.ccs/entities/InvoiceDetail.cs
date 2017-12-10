using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceDetail
    {
        public long InvoicedetailId { get; set; }
        public long? ContainerId { get; set; }
        public int? SecondExportImmunity { get; set; }
        public int? Move { get; set; }
        public decimal? HighWeightPrice { get; set; }
        public int? FullStrip { get; set; }
        public int? VagonStrip { get; set; }
        public decimal? ContentStrip { get; set; }
        public decimal? StorageTime { get; set; }
        public decimal? CfsStorageTime { get; set; }
        public decimal? CfsStorageWeight { get; set; }
        public int? NumberOfAutomobilesInContainer { get; set; }
        public int? NumberOfAutomobileRestrainInContainer { get; set; }
        public decimal? ReeferMonitoringTime { get; set; }
        public decimal? InvoiceStorageTime { get; set; }
        public decimal? PmCost { get; set; }
        public long? InvoiceMasterId { get; set; }

        public InvoiceMaster InvoiceMaster { get; set; }
    }
}
