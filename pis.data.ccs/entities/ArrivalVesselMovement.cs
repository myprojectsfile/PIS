using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ArrivalVesselMovement
    {
        public long VesselMovementId { get; set; }
        public int? EventType { get; set; }
        public DateTime? EventDate { get; set; }
        public string LocationName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string BookingNumber { get; set; }
        public long? ArrivalId { get; set; }
    }
}
