using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityToolbarRelServicesAndWorkflows
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public int? WorkflowId { get; set; }
        public bool? Automatic { get; set; }
        public bool? UsedOtherLocation { get; set; }
        public int? Priority { get; set; }
        public int? WorkFlowListNo { get; set; }
    }
}
