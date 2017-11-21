using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SyncKeyMap
    {
        public int MapId { get; set; }
        public string TableName { get; set; }
        public string KeyName { get; set; }
        public string MasterValue { get; set; }
        public string OfflineValue { get; set; }
        public int? GroupId { get; set; }
    }
}
