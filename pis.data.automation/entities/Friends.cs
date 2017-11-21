using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Friends
    {
        public int FriendId { get; set; }
        public string FriendName { get; set; }
        public int UserId { get; set; }
        public short? Priority { get; set; }
    }
}
