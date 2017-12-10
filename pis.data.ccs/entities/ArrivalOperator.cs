using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ArrivalOperator
    {
        public long ArrivalOperatorId { get; set; }
        public long ArrivalId { get; set; }
        public short OperatorId { get; set; }
        public long ArrivalTypeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Description { get; set; }

        public ArrivalNotice Arrival { get; set; }
        public Types ArrivalType { get; set; }
        public Operator Operator { get; set; }
    }
}
