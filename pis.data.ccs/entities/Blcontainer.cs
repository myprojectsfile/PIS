using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Blcontainer
    {
        public Blcontainer()
        {
            DealingReceiptContainer = new HashSet<DealingReceiptContainer>();
        }

        public long Blcid { get; set; }
        public long ContainerId { get; set; }
        public long Blid { get; set; }
        public int? PackagesCount { get; set; }
        public string PackageType { get; set; }
        public double? Gross { get; set; }

        public Bl Bl { get; set; }
        public Container Container { get; set; }
        public ICollection<DealingReceiptContainer> DealingReceiptContainer { get; set; }
    }
}
