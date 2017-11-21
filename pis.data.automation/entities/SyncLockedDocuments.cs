using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SyncLockedDocuments
    {
        public int LockId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public DateTime LockDate { get; set; }
        public int LockerRoleId { get; set; }
    }
}
