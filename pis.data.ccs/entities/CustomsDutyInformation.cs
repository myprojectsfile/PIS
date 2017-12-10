using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CustomsDutyInformation
    {
        public long Id { get; set; }
        public decimal? TaxesAmount { get; set; }
        public decimal? TaxesBase { get; set; }
        public string TaxesCode { get; set; }
        public decimal? TaxesRate { get; set; }
        public long DeclaredCommodityInformationId { get; set; }
    }
}
