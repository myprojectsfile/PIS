using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class GroupPermission
    {
        public short GroupId { get; set; }
        public int OperationId { get; set; }
        public bool Status { get; set; }

        public Group Group { get; set; }
        public Operation Operation { get; set; }
    }
}
