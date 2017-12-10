using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class PortAvailability
    {
        public long PortAvailabilityId { get; set; }
        public string ContainerNumber { get; set; }
        public long? ImportContainerId { get; set; }
        public long? ExportContainerId { get; set; }
        public long? CargoContainerId { get; set; }
        public DateTime? ImportDate { get; set; }
        public int? AreaId { get; set; }
        public string Yard { get; set; }
        public DateTime? ExportDate { get; set; }
        public bool? IsExited { get; set; }
        public long? ImportGateDeparureId { get; set; }
        public string ExportGateDepartureNo { get; set; }
    }
}
