using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class LegalReference
    {
        public int RoleId { get; set; }
        public int LegalId { get; set; }
        public short LegalType { get; set; }
    }
}
