using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ExportReceiptContainer
    {
        public long ExportReceiptId { get; set; }
        public long ContainerId { get; set; }

        public Container Container { get; set; }
    }
}
