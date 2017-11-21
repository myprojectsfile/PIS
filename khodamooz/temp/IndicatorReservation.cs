using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class IndicatorReservation
    {
        public int ReserveId { get; set; }
        public int IndicatorId { get; set; }
        public string IndicatorType { get; set; }
        public int ReserverUserId { get; set; }
        public int ReserverRoleId { get; set; }
        public DateTime ReserveDate { get; set; }
        public int IndicatorNo { get; set; }
        public string IndicatorFormula { get; set; }
        public string IndicatorPrefix { get; set; }
        public string IndicatorPostfix { get; set; }
        public int EntityTypeCode { get; set; }
        public int InnerNo { get; set; }
        public string EntityNumberRule { get; set; }
        public string EntityAbrName { get; set; }
        public DateTime StartValidDate { get; set; }
        public DateTime EndValidDate { get; set; }
        public bool? CurrentPriod { get; set; }
    }
}
