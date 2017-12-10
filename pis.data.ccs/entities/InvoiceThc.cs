using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceThc
    {
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
        public string InvoiceGroup { get; set; }
        public decimal? PayableAmount { get; set; }
        public string Description { get; set; }
        public bool? InvoiceStatus { get; set; }
        public byte? Paid { get; set; }
        public long? ArrivalId { get; set; }
        public string ShippingName { get; set; }
        public int? DischargeLoadingWithoutWire { get; set; }
        public int? DischargeLoadingWithWire { get; set; }
        public int? ShippingLineId { get; set; }
        public int? VesselSize { get; set; }
        public decimal? AgentTranshipGrassAmount { get; set; }
        public long? ParentId { get; set; }
        public bool? CorrectionStatus { get; set; }
        public string TypeOfService { get; set; }
        public short? OperatorId { get; set; }
        public decimal? OperatorLinerVesselDiscount { get; set; }
        public decimal? OperatorPerformanceDiscount { get; set; }
        public decimal? OperatorShareDuty { get; set; }
        public decimal? OperatorShareGross { get; set; }
        public decimal? OperatorShareTax { get; set; }
        public decimal? OperatorShareTranshipGross { get; set; }
        public decimal? OperatorTranshipDiscount { get; set; }
        public decimal? PortLinerVesselDiscount { get; set; }
        public decimal? PortPerformanceDiscount { get; set; }
        public decimal? PortShareDuty { get; set; }
        public decimal? PortShareGross { get; set; }
        public decimal? PortShareTax { get; set; }
        public decimal? PortShareTranshipGross { get; set; }
        public decimal? PortTranshipDiscount { get; set; }
        public DateTime? ThccalculateBaseDate { get; set; }
        public string OperatorSerialNumber { get; set; }
        public decimal? SanaRate { get; set; }
        public long? ReceiptId { get; set; }
    }
}
