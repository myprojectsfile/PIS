using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class TempTablePermission
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public byte? Type { get; set; }
    }
}
