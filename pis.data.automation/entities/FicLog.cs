using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FicLog
    {
        public int LogId { get; set; }
        public int? RuleId { get; set; }
        public int? RoleId { get; set; }
        public int? ActionCode { get; set; }
        public int? SenderId { get; set; }
        public int? SenderRoleId { get; set; }
        public int? Priority { get; set; }
        public int? SecurityLevelCode { get; set; }
        public int? SendReceiversCode { get; set; }
        public int? Ec { get; set; }
        public int? Etc { get; set; }
        public DateTime? SaveDate { get; set; }
        public string EntityNumber { get; set; }
        public string ImportEntityNumber { get; set; }
        public string ExportEntityNumber { get; set; }
        public string EntityTitle { get; set; }
        public string HameshTitle { get; set; }
        public string HameshContent { get; set; }
    }
}
