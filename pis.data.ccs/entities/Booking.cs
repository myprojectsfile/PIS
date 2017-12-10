using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Booking
    {
        public long BookingId { get; set; }
        public string VesselName { get; set; }
        public string VoyageNumber { get; set; }
        public DateTime Eta { get; set; }
        public string BookingNumber { get; set; }
    }
}
