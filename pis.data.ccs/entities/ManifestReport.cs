using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestReport
    {
        public int Id { get; set; }
        public string ReportNameFarsi { get; set; }
        public string ReportEnglisName { get; set; }
        public string ReportUrl { get; set; }
    }
}
