using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ThctariffMove
    {
        public long ThcmoveId { get; set; }
        public string ClassType { get; set; }
        public long? MoveSummin { get; set; }
        public long? MoveSumMax { get; set; }
        public int? ThcmovePercent { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
