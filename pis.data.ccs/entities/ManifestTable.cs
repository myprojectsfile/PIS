using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestTable
    {
        public ManifestTable()
        {
            ManifestField = new HashSet<ManifestField>();
        }

        public short TableId { get; set; }
        public string TableName { get; set; }

        public ICollection<ManifestField> ManifestField { get; set; }
    }
}
