using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MetaDataReportQuery
    {
        public int MetaDataReportQueryId { get; set; }
        public string MetaDataReportQueryTitle { get; set; }
        public string MetaDataReportQueryContent { get; set; }
        public string MetaDataReportQueryDesc { get; set; }
        public int ReportGroupId { get; set; }
    }
}
