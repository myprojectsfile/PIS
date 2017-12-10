using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class VesselMovementPosition
    {
        public long VesselMovementPositionId { get; set; }
        public long? ArrivalId { get; set; }
        public string LocationName { get; set; }
        public int? PositionTop { get; set; }
        public int? PositionLeft { get; set; }
        public byte? SegmentNo { get; set; }
    }
}
