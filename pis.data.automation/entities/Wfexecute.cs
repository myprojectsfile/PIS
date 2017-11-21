using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Wfexecute
    {
        public int ExecuteId { get; set; }
        public int? Wfid { get; set; }
        public string AppName { get; set; }
        public int? UserId { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public string ContentXml { get; set; }
        public int? WfversionId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Status { get; set; }
    }
}
