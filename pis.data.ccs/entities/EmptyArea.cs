using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class EmptyArea
    {
        public long Id { get; set; }
        public long? StripAreaId { get; set; }
        public long? EmptyAreaId { get; set; }
        public long? LineId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? Status { get; set; }
    }
}
