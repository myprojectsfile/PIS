using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CorrectionLinkStatus
    {
        public CorrectionLinkStatus()
        {
            ManifestLinkCorrection = new HashSet<ManifestLinkCorrection>();
        }

        public short StatusId { get; set; }
        public string Name { get; set; }

        public ICollection<ManifestLinkCorrection> ManifestLinkCorrection { get; set; }
    }
}
