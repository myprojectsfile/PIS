using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool Removeable { get; set; }

        public ICollection<User> User { get; set; }
    }
}
