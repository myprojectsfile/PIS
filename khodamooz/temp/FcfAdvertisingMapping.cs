using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FcfAdvertisingMapping
    {
        public int AdvertisingMappingId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SourceEventId { get; set; }
        public int? DestinitionEventId { get; set; }
        public short EventType { get; set; }
        public short EventOperate { get; set; }
        public int ErrorFlag { get; set; }
        public string ViewErrorMessage { get; set; }
        public string TechnicalErrorMessage { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
