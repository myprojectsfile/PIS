using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CargoContainerContent
    {
        public long CargoContainerId { get; set; }
        public long CustomCargoId { get; set; }
        public int? PackageCount { get; set; }
        public double? GrossWeight { get; set; }
        public string StuffingArea { get; set; }
        public string StuffingCo { get; set; }
        public DateTime? StuffingDate { get; set; }
        public int? AreaId { get; set; }
        public string Yard { get; set; }
        public string WagonNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string HazardousCode { get; set; }
        public string HazardousVersion { get; set; }
        public long? ReceiptId { get; set; }

        public CargoContainer CargoContainer { get; set; }
        public Cargo CustomCargo { get; set; }
    }
}
