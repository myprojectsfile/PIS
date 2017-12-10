using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MinuteItem
    {
        public long MinuteItemId { get; set; }
        public string ContainerNumber { get; set; }
        public short? MinuteItemTypeId { get; set; }
        public long? MinuteId { get; set; }

        public Minute Minute { get; set; }
    }
}
