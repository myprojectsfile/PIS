using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int? ExistContainerCount { get; set; }
        public decimal? MaxAllowedCapacity { get; set; }
        public short AreaTypeId { get; set; }
        public short OperatorId { get; set; }
        public string AreaCode { get; set; }
        public decimal? Space { get; set; }
        public string Po { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? Status { get; set; }
        public string PersianName { get; set; }

        public AreaType AreaType { get; set; }
        public Operator Operator { get; set; }
    }
}
