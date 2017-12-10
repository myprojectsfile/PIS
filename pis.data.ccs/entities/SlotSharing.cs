using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class SlotSharing
    {
        public SlotSharing()
        {
            Bl = new HashSet<Bl>();
        }

        public long Id { get; set; }
        public long? ArrivalId { get; set; }
        public short? ShippingId { get; set; }
        public short? ShippingParnetId { get; set; }
        public long? ShipCount { get; set; }
        public int? ShippingLineId { get; set; }
        public int? _20full { get; set; }
        public int? _20mt { get; set; }
        public int? _40full { get; set; }
        public int? _40mt { get; set; }
        public long? Impdep { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? Status { get; set; }
        public bool? Isopen { get; set; }

        public ArrivalNotice Arrival { get; set; }
        public Types ImpdepNavigation { get; set; }
        public ShippingLine ShippingLine { get; set; }
        public ICollection<Bl> Bl { get; set; }
    }
}
