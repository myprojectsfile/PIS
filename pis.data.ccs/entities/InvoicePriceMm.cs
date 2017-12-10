using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoicePriceMm
    {
        public int Ipmmid { get; set; }
        public string Ipmmgroup { get; set; }
        public string IpmmcontainerSize { get; set; }
        public string Ipmmtype { get; set; }
        public decimal? Ipmmmin { get; set; }
        public decimal? Ipmmmax { get; set; }
        public decimal? Ipmmprice { get; set; }
        public string IpmmfarsiName { get; set; }
        public string TypeofImmtype { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
