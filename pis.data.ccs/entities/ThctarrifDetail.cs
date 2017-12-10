using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ThctarrifDetail
    {
        public long ThcId { get; set; }
        public string ThcName { get; set; }
        public string Value { get; set; }
        public string DomainName { get; set; }
        public string FarsiName { get; set; }
        public decimal? Price { get; set; }
        public bool? Ispercent { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
