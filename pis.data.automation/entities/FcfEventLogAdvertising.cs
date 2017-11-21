using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FcfEventLogAdvertising
    {
        public int EventAdvertisingId { get; set; }
        public int DocRegCode { get; set; }
        public int? EventCode { get; set; }
        public short EventType { get; set; }
        public short EventOperate { get; set; }
        public int ErrorFlag { get; set; }
        public string ViewErrorMessage { get; set; }
        public string TechnicalErrorMessage { get; set; }
        public string EventMoreInfo { get; set; }
    }
}
