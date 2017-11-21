using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SyncBaseInfoLastCodes
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public DateTime LastSyncTime { get; set; }
        public int RecordsCount { get; set; }
        public int? LastRecordId { get; set; }
    }
}
