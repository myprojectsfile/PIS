using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Event
    {
        public long EventId { get; set; }
        public int OperationId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Operation Operation { get; set; }
        public User User { get; set; }
    }
}
