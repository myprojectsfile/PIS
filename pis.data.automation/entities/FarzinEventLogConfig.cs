using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinEventLogConfig
    {
        public int RecId { get; set; }
        public string TableName { get; set; }
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
