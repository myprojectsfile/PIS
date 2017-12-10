using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class TaxExemption
    {
        public int TaxExemptionId { get; set; }
        public string TaxExemptionName { get; set; }
        public string TaxExemptionNumber { get; set; }
        public DateTime? TaxExemptionDateFrom { get; set; }
        public DateTime? TaxExemptionDateTo { get; set; }
        public DateTime? TaxExemptionDateCreate { get; set; }
        public DateTime? TaxExemptionDateModify { get; set; }
        public string TaxExemptionDescription { get; set; }
        public string TaxExemptionPortCode { get; set; }
        public bool? TaxExemptionHas { get; set; }
    }
}
