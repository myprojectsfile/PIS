using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class DischargeTally
    {
        public long DischargeTallyId { get; set; }
        public long DischargeId { get; set; }
        public string ContainerNumber { get; set; }
        public byte? Size { get; set; }
        public byte? Type { get; set; }
        public bool? FullEmpty { get; set; }
        public string TallyClerk { get; set; }
        public long? ContainerId { get; set; }
        public bool? IsDamage { get; set; }
        public bool? IsOg { get; set; }
        public bool? UseWire { get; set; }
        public string GantryCode { get; set; }

        public DischargeList Discharge { get; set; }
        public ContainerType TypeNavigation { get; set; }
    }
}
