using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngLocalLock
    {
        public int Id { get; set; }
        public int? EmailReceiveId { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? LockDate { get; set; }
    }
}
