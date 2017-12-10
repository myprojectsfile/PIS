using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Report
    {
        public Report()
        {
            ReportParameter = new HashSet<ReportParameter>();
            ReportRequiredField = new HashSet<ReportRequiredField>();
        }

        public int Id { get; set; }
        public string NameFa { get; set; }
        public string NameEn { get; set; }
        public string WebMehod { get; set; }
        public string ReportFile { get; set; }
        public string Category { get; set; }
        public string Host { get; set; }
        public short? Benumber { get; set; }
        public bool? IsWeekly { get; set; }
        public bool? Isenabled { get; set; }
        public int? Timespan { get; set; }

        public ICollection<ReportParameter> ReportParameter { get; set; }
        public ICollection<ReportRequiredField> ReportRequiredField { get; set; }
    }
}
