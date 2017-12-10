using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceThckey
    {
        public long InvoiceKeyId { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceKeyName { get; set; }
        public int? InvoiceCount { get; set; }
        public decimal? InvoicePrice { get; set; }
        public int? ContainerSize { get; set; }
        public int? ContainerType { get; set; }
        public int? EntryType { get; set; }
        public bool? FullEmpty { get; set; }
        public bool? IsDischarge { get; set; }
    }
}
