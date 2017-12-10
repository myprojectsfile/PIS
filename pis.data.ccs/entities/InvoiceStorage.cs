using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceStorage
    {
        public int InvoiceStorageId { get; set; }
        public string EntryType { get; set; }
        public string ContainerSize { get; set; }
        public string ContainerStatus { get; set; }
        public int? StrorageTimeMin { get; set; }
        public int? StorageTimeMax { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
