using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class TaskHistory
    {
        public int HistoryId { get; set; }
        public int TaskId { get; set; }
        public string TaskSubject { get; set; }
        public string TaskLocation { get; set; }
        public short TaskStatus { get; set; }
        public short TaskProgress { get; set; }
        public short PersonnelState { get; set; }
        public DateTime CreationDate { get; set; }
        public int? Etc { get; set; }
        public int? Ec { get; set; }
        public int? SendCode { get; set; }
    }
}
