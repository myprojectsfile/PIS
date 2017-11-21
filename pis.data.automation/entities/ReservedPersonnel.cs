using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class ReservedPersonnel
    {
        public int ReserveId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int ReserveRoleId { get; set; }
        public int ReserveUserId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CardTableXml { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
