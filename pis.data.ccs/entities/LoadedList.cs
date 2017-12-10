using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class LoadedList
    {
        public long LoadedListId { get; set; }
        public DateTime EndLoadedDate { get; set; }
        public long? VoyageId { get; set; }
        public short? OperatorId { get; set; }
    }
}
