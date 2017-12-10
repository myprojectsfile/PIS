using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Ship
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public string ShipImo { get; set; }
        public short? ShippingVesselId { get; set; }
        public string ShipCode { get; set; }
        public int? ShippingLineId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? Status { get; set; }
        public string ShipType { get; set; }
        public string CallSign { get; set; }
        public int? TotalTeu { get; set; }
        public decimal? Dwt { get; set; }
        public decimal? Grt { get; set; }
        public decimal? Nrt { get; set; }
        public decimal? Loa { get; set; }
        public string BuiltYear { get; set; }
        public float? Draft { get; set; }
        public string NationalityCode { get; set; }

        public Shipping ShippingVessel { get; set; }
    }
}
