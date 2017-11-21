using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class InternallegalReference
    {
        public int RoleId { get; set; }
        public int LegalId { get; set; }
        public short LegalType { get; set; }
    }
}
