using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class RolesDefaultPrintLayouts
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int DefaultLayoutId { get; set; }
    }
}
