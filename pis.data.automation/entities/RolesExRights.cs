using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class RolesExRights
    {
        public int RoleId { get; set; }
        public int RightId { get; set; }
        public string IsConfirm { get; set; }
        public string AcceptXml { get; set; }

        public Roles Role { get; set; }
    }
}
