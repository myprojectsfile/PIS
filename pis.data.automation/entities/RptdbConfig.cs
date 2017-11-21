using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class RptdbConfig
    {
        public int DbCode { get; set; }
        public string DbProvider { get; set; }
        public string ViewDbName { get; set; }
        public string Dsn { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public int? CommandTout { get; set; }
        public string ExportDbDsn { get; set; }
        public string ExportDbUid { get; set; }
        public string ExportDbPwd { get; set; }
        public string HtmlFilesPath { get; set; }
        public string WordFilesPath { get; set; }
        public string AccessFilesPath { get; set; }
        public string ExcelFilesPath { get; set; }
    }
}
