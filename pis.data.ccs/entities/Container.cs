using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Container
    {
        public Container()
        {
            Blcontainer = new HashSet<Blcontainer>();
            ExportReceiptContainer = new HashSet<ExportReceiptContainer>();
        }

        public long ContainerId { get; set; }
        public string ContainerNumber { get; set; }
        public int? IsocontainerCode { get; set; }
        public bool? FullEmpty { get; set; }
        public double? GrossWeight { get; set; }
        public double? TareWeight { get; set; }
        public string SealNumber { get; set; }
        public string Owner { get; set; }
        public string Agent { get; set; }
        public byte? MovementType { get; set; }
        public string SealingParty { get; set; }
        public bool? SealingCondition { get; set; }
        public string PortOfLoadingId { get; set; }
        public string PortOfDischargeId { get; set; }
        public string HazardousCode { get; set; }
        public string HazardousVersion { get; set; }
        public short? PageNo { get; set; }
        public short? FlashPoint { get; set; }
        public int? FlashPointUnit { get; set; }
        public string PackingGroup { get; set; }
        public short? Unit { get; set; }
        public int? AreaId { get; set; }
        public bool? Locked { get; set; }
        public string Destination { get; set; }
        public int? StaffingLocation { get; set; }
        public DateTime? DischargeDate { get; set; }
        public byte? TypeOfLoading { get; set; }
        public byte? ExitType { get; set; }
        public string Yard { get; set; }
        public DateTime? YardDate { get; set; }
        public short? OperatorId { get; set; }
        public short? Rftemperature { get; set; }
        public int? RftemperatureUnit { get; set; }
        public bool? MoveCfs { get; set; }
        public string PortOfDestination { get; set; }
        public string PortOfTranship { get; set; }
        public int? TransportMode { get; set; }

        public Container ContainerNavigation { get; set; }
        public IsocontainerCode IsocontainerCodeNavigation { get; set; }
        public MovementType MovementTypeNavigation { get; set; }
        public SealingParty SealingPartyNavigation { get; set; }
        public Container InverseContainerNavigation { get; set; }
        public ICollection<Blcontainer> Blcontainer { get; set; }
        public ICollection<ExportReceiptContainer> ExportReceiptContainer { get; set; }
    }
}
