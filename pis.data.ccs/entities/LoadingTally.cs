using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class LoadingTally
    {
        public long LoadingTallyId { get; set; }
        public string ContainerNumber { get; set; }
        public byte? Size { get; set; }
        public byte? Type { get; set; }
        public double? Weight { get; set; }
        public string Pod { get; set; }
        public long LoadingListId { get; set; }
        public DateTime? LoadingDate { get; set; }
        public string FullEmpty { get; set; }
        public string Destination { get; set; }
        public string Owner { get; set; }
        public string Yard { get; set; }

        public LoadingList LoadingList { get; set; }
    }
}
