using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RolesExLocationAccess = new HashSet<RolesExLocationAccess>();
            RolesExRights = new HashSet<RolesExRights>();
            RolesExTimeAccess = new HashSet<RolesExTimeAccess>();
        }

        public int RoleId { get; set; }
        public int OrganizationRoleId { get; set; }
        public string RoleName { get; set; }
        public int? UserId { get; set; }
        public bool? CardTableStatus { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public int? ParentId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? LastRefreshTime { get; set; }
        public bool? IsDefForCardTable { get; set; }
        public int? OriginRoleId { get; set; }
        public string RoleLocation { get; set; }
        public bool? InternalCardTableStatus { get; set; }
        public string Title { get; set; }

        public ICollection<RolesExLocationAccess> RolesExLocationAccess { get; set; }
        public ICollection<RolesExRights> RolesExRights { get; set; }
        public ICollection<RolesExTimeAccess> RolesExTimeAccess { get; set; }
    }
}
