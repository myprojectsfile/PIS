using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MasterHokm
    {
        public long Id { get; set; }
        public long? ArriavalId { get; set; }
        public long? VoyageId { get; set; }
        public string TrackNum { get; set; }
        public string PortDes { get; set; }
        public bool? Confirm { get; set; }
        public DateTime? DateConfirm { get; set; }
        public DateTime? DateReg { get; set; }
        public long? ShippingId { get; set; }
        public bool? Cancel { get; set; }
        public string Description { get; set; }
    }
}
