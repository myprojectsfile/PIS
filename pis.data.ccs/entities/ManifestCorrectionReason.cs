using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestCorrectionReason
    {
        public ManifestCorrectionReason()
        {
            ManifestCorrection = new HashSet<ManifestCorrection>();
        }

        public int ReasonId { get; set; }
        public string ReasonName { get; set; }

        public ICollection<ManifestCorrection> ManifestCorrection { get; set; }
    }
}
