using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Group
    {
        public Group()
        {
            GroupPermission = new HashSet<GroupPermission>();
            UserGroup = new HashSet<UserGroup>();
        }

        public short GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

        public ICollection<GroupPermission> GroupPermission { get; set; }
        public ICollection<UserGroup> UserGroup { get; set; }
    }
}
