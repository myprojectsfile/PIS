using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Cfsdeparture
    {
        public long CfsdepartureId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? AreaId { get; set; }
        public string ContainerNumber { get; set; }
        public string Destination { get; set; }
        public long? VoyageId { get; set; }
        public bool? ServiceType { get; set; }
    }
}
