using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class UserGroup
    {
        public short GroupId { get; set; }
        public int UserId { get; set; }

        public Group Group { get; set; }
        public User User { get; set; }
    }
}
