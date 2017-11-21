using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class PersonalLock
    {
        public int PersonalLockId { get; set; }
        public int RoleId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public DateTime LockTime { get; set; }
    }
}
