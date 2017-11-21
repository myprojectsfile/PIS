using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class RolesExLocationAccess
    {
        public int LocationCode { get; set; }
        public int RoleId { get; set; }
        public string Ip { get; set; }
        public int Count { get; set; }

        public Roles Role { get; set; }
    }
}
