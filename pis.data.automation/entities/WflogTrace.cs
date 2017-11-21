using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class WflogTrace
    {
        public int Id { get; set; }
        public int? WfexecutedId { get; set; }
        public int? FromScenarioCode { get; set; }
        public string FromScenarioName { get; set; }
        public int? ToScenarioCode { get; set; }
        public string ToScenarioName { get; set; }
        public int? ExecuterId { get; set; }
        public string Status { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
