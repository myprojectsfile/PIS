using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class UsersDevice
    {
        public long Pk { get; set; }
        public int UserId { get; set; }
        public string Uuid { get; set; }
        public string Serial { get; set; }
    }
}
