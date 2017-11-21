using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SyncOfflineChangesLog
    {
        public int LogId { get; set; }
        public string TableName { get; set; }
        public int Action { get; set; }
        public string Condition { get; set; }
        public DateTime LogDate { get; set; }
    }
}
