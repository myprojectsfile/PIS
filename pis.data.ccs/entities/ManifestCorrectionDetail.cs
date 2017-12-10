using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestCorrectionDetail
    {
        public short FieldId { get; set; }
        public string Value { get; set; }
        public string OldValue { get; set; }
        public bool? Sold { get; set; }
        public Guid CorrectionId { get; set; }
        public Guid Id { get; set; }
        public string UniqueId { get; set; }

        public ManifestCorrection Correction { get; set; }
        public ManifestField Field { get; set; }
    }
}
