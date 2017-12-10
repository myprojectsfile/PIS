using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class TrackingObjects
    {
        public long TrackingId { get; set; }
        public long? EntityId { get; set; }
        public long? EntityTypeId { get; set; }
        public long? OperationTypeId { get; set; }
        public DateTime? EventDate { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsOperatorService { get; set; }
    }
}
