using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class UsersDevice
    {
        public long Pk { get; set; }
        public int UserId { get; set; }
        public string Uuid { get; set; }
        public string Serial { get; set; }
    }
}
