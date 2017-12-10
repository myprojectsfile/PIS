using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class DealingReceiptContainer
    {
        public long Blcid { get; set; }
        public long DealingReceiptId { get; set; }

        public Blcontainer Blc { get; set; }
    }
}
