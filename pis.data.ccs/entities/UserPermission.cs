using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class UserPermission
    {
        public int UserId { get; set; }
        public bool Status { get; set; }
        public int OperationId { get; set; }

        public User User { get; set; }
    }
}
