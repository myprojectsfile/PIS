using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class DischargeList
    {
        public DischargeList()
        {
            DischargeTally = new HashSet<DischargeTally>();
        }

        public long DischargeListId { get; set; }
        public DateTime DischargeDate { get; set; }
        public long VoyageId { get; set; }
        public short? OperatorId { get; set; }

        public Voyage Voyage { get; set; }
        public ICollection<DischargeTally> DischargeTally { get; set; }
    }
}
