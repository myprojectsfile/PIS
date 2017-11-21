using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityLocalLock
    {
        public int Id { get; set; }
        public string EntityTypeName { get; set; }
        public int EntityTypeCode { get; set; }
        public int EntityCode { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime? LockDate { get; set; }
    }
}
