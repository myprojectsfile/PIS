using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ExitPermission
    {
        public long ExitPermissionId { get; set; }
        public string ExitPermissionNumber { get; set; }
        public long VoyageId { get; set; }
        public string ContainerNumber { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? ExitPackageCount { get; set; }
        public int? PackageCount { get; set; }
        public string Destination { get; set; }
        public string VehicleNumber { get; set; }
        public short? VehicleType { get; set; }
        public string TerminalName { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string CustomLicenceNo { get; set; }
        public DateTime? CustomLicenceDate { get; set; }
        public string ExitPermissionType { get; set; }
        public string TemproraryLicenceNo { get; set; }
        public string ExitType { get; set; }
        public double? Weight { get; set; }
        public int AreaId { get; set; }
        public bool? ServiceType { get; set; }
        public long? ContainerId { get; set; }
        public string SerialNumberVerification { get; set; }
        public string LoadingPermissionNumber { get; set; }
        public bool? IsReturn { get; set; }
        public DateTime? ExitRealDate { get; set; }
        public string Receiver { get; set; }
        public int? ContainerStatus { get; set; }

        public ExitPermission ExitPermissionNavigation { get; set; }
        public ExitPermission InverseExitPermissionNavigation { get; set; }
    }
}
