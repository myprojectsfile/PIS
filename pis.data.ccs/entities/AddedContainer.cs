using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class AddedContainer
    {
        public string ContainerNumber { get; set; }
        public bool? FullEmpty { get; set; }
        public double? GrossWeight { get; set; }
        public double? TareWeight { get; set; }
        public string SealNumber { get; set; }
        public string Owner { get; set; }
        public string Agent { get; set; }
        public byte? MovementType { get; set; }
        public string SealingParty { get; set; }
        public bool? SealingCondition { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string HazardousCode { get; set; }
        public string HazardousVersion { get; set; }
        public short? PageNo { get; set; }
        public short? FlashPoint { get; set; }
        public int? FlashPointUnit { get; set; }
        public string PackingGroup { get; set; }
        public short? Unit { get; set; }
        public Guid Id { get; set; }
        public Guid CorrectionId { get; set; }
        public int? PackagesCount { get; set; }
        public byte? ContainerType { get; set; }
        public byte? ContainerSize { get; set; }
        public string PackageType { get; set; }
        public short? Rftemperature { get; set; }
        public string PortOfDestination { get; set; }
        public string PortOfTranship { get; set; }
        public int? RftemperatureUnit { get; set; }
        public DateTime? DischareDate { get; set; }
        public int? AreaId { get; set; }
        public short? OperatorId { get; set; }
        public string Yard { get; set; }

        public ContainerType ContainerTypeNavigation { get; set; }
        public ManifestCorrection Correction { get; set; }
        public HazardousCode HazardousCodeNavigation { get; set; }
        public MovementType MovementTypeNavigation { get; set; }
        public SealingParty SealingPartyNavigation { get; set; }
    }
}
