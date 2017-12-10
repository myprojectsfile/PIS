using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class OperatorAgent
    {
        public short OperatorId { get; set; }
        public int UserId { get; set; }

        public Operator Operator { get; set; }
        public User User { get; set; }
    }
}
