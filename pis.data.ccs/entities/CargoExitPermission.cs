using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CargoExitPermission
    {
        public long CargoExitPermissionId { get; set; }
        public long? VoyageId { get; set; }
        public int? AreaId { get; set; }
        public DateTime? ExitDate { get; set; }
        public string Blnumber { get; set; }
        public short? VehicleType { get; set; }
        public string VehicleNumber { get; set; }
        public string ExitPermissionNumber { get; set; }
        public string Destination { get; set; }
        public int? PackageCount { get; set; }
        public string ContainerNumber { get; set; }
        public string CustomPermission { get; set; }
        public string IssueBy { get; set; }
        public DateTime? IssueDate { get; set; }
        public bool? ServiceType { get; set; }
        public long? ContainerId { get; set; }
        public string SerialNumberVerification { get; set; }
        public DateTime? ExitRealDate { get; set; }
        public string Receiver { get; set; }
    }
}
