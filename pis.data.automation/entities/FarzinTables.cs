using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinTables
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string PrimaryKeyNames { get; set; }
        public string IdentityFieldName { get; set; }
        public int? SendPriority { get; set; }
        public bool IsBaseTable { get; set; }
        public bool? TransferPerRole { get; set; }
        public string RoleIdfieldName { get; set; }
        public string UserIdfieldName { get; set; }
        public bool? TriggerRequired { get; set; }
        public string SyncType { get; set; }
    }
}
