using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestField
    {
        public ManifestField()
        {
            ManifestCorrectionDetail = new HashSet<ManifestCorrectionDetail>();
        }

        public short FieldId { get; set; }
        public string FieldName { get; set; }
        public short TableId { get; set; }

        public ManifestTable Table { get; set; }
        public ICollection<ManifestCorrectionDetail> ManifestCorrectionDetail { get; set; }
    }
}
