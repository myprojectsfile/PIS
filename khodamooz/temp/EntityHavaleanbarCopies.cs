using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityHavaleanbarCopies
    {
        public int CopyCode { get; set; }
        public int EntityCode { get; set; }
        public int CopyNumber { get; set; }
        public int? AvailabilityCode { get; set; }
        public int? PhysicalQualityCode { get; set; }
        public int? LocationCode { get; set; }
        public int? CopyTypeCode { get; set; }
        public bool? OriginalCopy { get; set; }
        public string BarCode { get; set; }
        public int? CreatorCode { get; set; }
        public int? ServerCode { get; set; }
        public bool? Locked { get; set; }
        public bool? LocalLock { get; set; }
    }
}
