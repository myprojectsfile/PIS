using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CargoContainer
    {
        public CargoContainer()
        {
            CargoContainerContent = new HashSet<CargoContainerContent>();
        }

        public long CargoContainerId { get; set; }
        public long CargoId { get; set; }
        public long? ContainerId { get; set; }
        public int? PackagesCount { get; set; }
        public string Felxi { get; set; }
        public double? GrossWeight { get; set; }
        public string Package { get; set; }
        public string PackageTypeCode { get; set; }
        public string StuffingArea { get; set; }
        public string StuffingCo { get; set; }
        public DateTime? StuffingDate { get; set; }
        public string Agent { get; set; }
        public int? AreaId { get; set; }
        public string ContainerNumber { get; set; }
        public string Destination { get; set; }
        public DateTime? DischargeDate { get; set; }
        public byte? ExitType { get; set; }
        public short? FlashPoint { get; set; }
        public int? FlashPointUnit { get; set; }
        public bool? FullEmpty { get; set; }
        public string HazardousCode { get; set; }
        public string HazardousVersion { get; set; }
        public int? IsocontainerCode { get; set; }
        public long? LineId { get; set; }
        public bool? Locked { get; set; }
        public bool? MoveCfs { get; set; }
        public byte? MovementType { get; set; }
        public short? OperatorId { get; set; }
        public string Owner { get; set; }
        public string PackingGroup { get; set; }
        public short? PageNo { get; set; }
        public string PortOfDestination { get; set; }
        public string PortOfDischargeId { get; set; }
        public string PortOfLoadingId { get; set; }
        public string PortOfTranship { get; set; }
        public short? Rftemperature { get; set; }
        public int? RftemperatureUnit { get; set; }
        public bool? SealingCondition { get; set; }
        public string SealingParty { get; set; }
        public string SealNumber { get; set; }
        public int? StaffingLocation { get; set; }
        public double? TareWeight { get; set; }
        public byte? TypeOfLoading { get; set; }
        public short? Unit { get; set; }
        public string Yard { get; set; }
        public DateTime? YardDate { get; set; }
        public long? VoyageId { get; set; }
        public string WagonNo { get; set; }
        public string TallyClerk { get; set; }

        public ICollection<CargoContainerContent> CargoContainerContent { get; set; }
    }
}
