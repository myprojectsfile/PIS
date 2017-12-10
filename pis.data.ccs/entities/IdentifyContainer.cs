using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class IdentifyContainer
    {
        public long Id { get; set; }
        public long? ContainerId { get; set; }
        public string Bottom { get; set; }
        public string Left { get; set; }
        public string Front { get; set; }
        public string Top { get; set; }
        public string Right { get; set; }
        public string Back { get; set; }
        public long? Type { get; set; }
        public int? PrintCount { get; set; }
        public string TrackNumber { get; set; }
        public DateTime? Date { get; set; }
    }
}
