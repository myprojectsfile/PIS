using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class DetaileHokm
    {
        public long Id { get; set; }
        public long? HokmId { get; set; }
        public long? Blid { get; set; }
        public long? SlotId { get; set; }
        public long? ContainerId { get; set; }
        public string ContainerNumber { get; set; }
        public bool? Cancel { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
