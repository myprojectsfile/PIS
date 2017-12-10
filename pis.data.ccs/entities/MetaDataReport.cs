using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MetaDataReport
    {
        public int MetaDataReportId { get; set; }
        public string MetaDataReportTitle { get; set; }
        public byte[] MetaDataReportContent { get; set; }
        public string MetaDataReportDesc { get; set; }
        public int MetaDataReportGroupId { get; set; }
        public int? MetaDataReportQueryId { get; set; }
    }
}
