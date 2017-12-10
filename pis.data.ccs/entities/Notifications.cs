using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Notifications
    {
        public long Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long TypeId { get; set; }
        public int OperationId { get; set; }
    }
}
