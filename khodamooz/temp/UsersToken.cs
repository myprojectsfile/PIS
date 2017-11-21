using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class UsersToken
    {
        public int UserId { get; set; }
        public string TokenSerialNo { get; set; }
        public bool? TokenForced { get; set; }
        public bool? TokenSuspend { get; set; }

        public Users User { get; set; }
    }
}
