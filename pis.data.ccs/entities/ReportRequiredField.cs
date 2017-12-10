using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ReportRequiredField
    {
        public int RequiredFiledId { get; set; }
        public int? ReportId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }

        public Report Report { get; set; }
    }
}
