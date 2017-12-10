using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class BillSharing
    {
        public long BillSharingId { get; set; }
        public long? BillTypeId { get; set; }
        public short? OperatorId { get; set; }
        public decimal? SharePercent { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool? Status { get; set; }
    }
}
