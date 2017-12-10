using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceThcdetail
    {
        public long InvoiceDetailId { get; set; }
        public long InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public string VoyageNumberEntry { get; set; }
        public string VoyageNumberExit { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string VesselName { get; set; }
        public string PortOperatorName { get; set; }
        public string PortOfOrigine { get; set; }
        public string NextPort { get; set; }
        public string LastPort { get; set; }
        public string DestinationPort { get; set; }
        public string VesselType { get; set; }
        public int? BayToBayMoves1 { get; set; }
        public int? BayToBayMoves2 { get; set; }
        public int? StorageDoorOpenClose1 { get; set; }
        public int? StorageDoorOpenClose2 { get; set; }
        public int? StockBoxMoves { get; set; }
        public int? FreeTimeWorkHours { get; set; }
        public DateTime? BerthedOn { get; set; }
        public DateTime? UnBerthedOn { get; set; }
        public int? VesselTotalMoves { get; set; }
        public decimal? VesselSizeDiscount { get; set; }
        public decimal? VesselPerformanceDiscount { get; set; }
        public string Currency { get; set; }
        public decimal? UsdRoe { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public string AgentPhone { get; set; }
        public string AgentFax { get; set; }
        public int? AgentAnnulMove { get; set; }
        public int? AgentContractualMove { get; set; }
        public string AgentType { get; set; }
        public decimal? AgentGrossAmount { get; set; }
        public decimal? AgentContractualTranshipMoveDiscount { get; set; }
        public decimal? AgentTax { get; set; }
        public decimal? AgentDuty { get; set; }
        public decimal? AgentGrandTotal { get; set; }
        public string ContainerNumber { get; set; }
        public string ContainerType { get; set; }
        public string ContainerSize { get; set; }
        public string ContainerStatus { get; set; }
        public string TerminalType { get; set; }
        public string StowType { get; set; }
        public string SpecialEquipment { get; set; }
        public int? HighWeightPrice { get; set; }
        public string ReeferPlugUnPlug { get; set; }
        public string EntryType { get; set; }
        public long? ArrivalId { get; set; }
        public long? VoyageId { get; set; }
        public string ShippingName { get; set; }
        public int? ShippingLineId { get; set; }
        public long? ContainerId { get; set; }
    }
}
