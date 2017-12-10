using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Cartable
    {
        public long CartableId { get; set; }
        public long MessageId { get; set; }
        public int UserId { get; set; }
        public bool IsRead { get; set; }

        public Message Message { get; set; }
        public User User { get; set; }
    }
}
