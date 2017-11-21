using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class RolesDefaultPrintLayouts
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int DefaultLayoutId { get; set; }
    }
}
