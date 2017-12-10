using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ReportParameter
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Required { get; set; }
        public string LableTextFa { get; set; }
        public string LabelTextEn { get; set; }
        public string EnumerationTextFa { get; set; }
        public string EnumerationTextEn { get; set; }
        public bool? IsBounded { get; set; }
        public bool? IsParameter { get; set; }
        public byte? IsRequiredMaybe { get; set; }

        public Report Report { get; set; }
    }
}
