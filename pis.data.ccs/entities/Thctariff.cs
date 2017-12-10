using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Thctariff
    {
        public long TariffId { get; set; }
        public string EntryType { get; set; }
        public string ContainerSize { get; set; }
        public decimal? TariffRate { get; set; }
        public string ContainerStatus { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
