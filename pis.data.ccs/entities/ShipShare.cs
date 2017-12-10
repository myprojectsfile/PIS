using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ShipShare
    {
        public long ShipShareId { get; set; }
        public short? ShippingParentId { get; set; }
        public short? ShippingId { get; set; }
        public string VesselName { get; set; }
        public string VoyageNumber { get; set; }
        public DateTime? Eta { get; set; }
        public int? ShipCount { get; set; }
        public string Imo { get; set; }
    }
}
