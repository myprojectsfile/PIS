using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Rptstructure
    {
        public int RptId { get; set; }
        public int? DbCode { get; set; }
        public string En { get; set; }
        public string Fn { get; set; }
        public string Password { get; set; }
        public string OutputType { get; set; }
        public int? RptTemplate { get; set; }
        public int? DistinctRecords { get; set; }
        public int? PageBreak { get; set; }
        public string Description { get; set; }
        public string CtrlText { get; set; }
        public string HeaderClientHeight { get; set; }
        public string BodyClientHeight { get; set; }
        public string FooterClientHeight { get; set; }
        public string HeaderSize { get; set; }
        public string BodySize { get; set; }
        public string FooterSize { get; set; }
        public string Structure { get; set; }
        public string HeaderHtml { get; set; }
        public string BodyHtml { get; set; }
        public string FooterHtml { get; set; }
        public string SqlexportTblPreName { get; set; }
        public string SqlexportTblMidName { get; set; }
        public string SqlexportTblPostName { get; set; }
        public bool? UseInSpecialSearch { get; set; }
    }
}
