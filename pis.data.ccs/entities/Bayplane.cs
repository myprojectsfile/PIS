using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Bayplane
    {
        public long Id { get; set; }
        public long? ContainerId { get; set; }
        public long? VoyageId { get; set; }
        public int? Rftemperature { get; set; }
        public short? RftemperatureUnit { get; set; }
        public string HazardouseCode { get; set; }
        public string HazardousVersion { get; set; }
        public string PortOfDischargeCode { get; set; }
        public string PortOfLoadingCode { get; set; }
        public string PortOfDestination { get; set; }
        public double? GrossWeight { get; set; }
        public bool? FullEmpty { get; set; }
        public string IsocontainerCode { get; set; }
        public string Position { get; set; }
        public string Carrier { get; set; }
        public string ContainerNumber { get; set; }
        public DateTime? Createdate { get; set; }
        public int? UserId { get; set; }
        public string PageNo { get; set; }
    }
}
