using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class UserPasswordHistory
    {
        public long HistoryId { get; set; }
        public int? UserId { get; set; }
        public string OldPassword { get; set; }
        public DateTime? EventDate { get; set; }
        public string Description { get; set; }
    }
}
