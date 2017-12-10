using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MetaDataReportGroup
    {
        public int ReportGroupId { get; set; }
        public string ReportGroupTitle { get; set; }
        public int? ReportGroupLink { get; set; }
        public string ReportGroupDesc { get; set; }
    }
}
