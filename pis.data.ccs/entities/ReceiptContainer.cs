using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ReceiptContainer
    {
        public long ReceiptContainerId { get; set; }
        public long? ContainerId { get; set; }
        public long? ReceiptId { get; set; }
        public string Blnumber { get; set; }
        public string ReceiptNumber { get; set; }
        public string Consignee { get; set; }
    }
}
