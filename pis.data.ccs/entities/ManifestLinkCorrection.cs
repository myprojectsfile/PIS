using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestLinkCorrection
    {
        public Guid Id { get; set; }
        public Guid CorrectionId { get; set; }
        public string SourceBlnumber { get; set; }
        public string TargetBlnumber { get; set; }
        public string ContainerNumber { get; set; }
        public short Status { get; set; }
        public decimal? Gross { get; set; }
        public int? PackageCount { get; set; }
        public long? SplitType { get; set; }

        public ManifestCorrection Correction { get; set; }
        public CorrectionLinkStatus StatusNavigation { get; set; }
    }
}
