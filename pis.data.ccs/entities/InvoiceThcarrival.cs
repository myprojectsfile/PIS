using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class InvoiceThcarrival
    {
        public long Id { get; set; }
        public int? VesselTotalMoves { get; set; }
        public int? BayToBayMoves1 { get; set; }
        public int? BayToBayMoves2 { get; set; }
        public int? StorageDoorOpenClose1 { get; set; }
        public int? StorageDoorOpenClose2 { get; set; }
        public int? StockBoxMoves { get; set; }
        public int? FreeTimeWorkHours { get; set; }
        public int? AgentAnnulMove { get; set; }
        public int? AgentContractualMove { get; set; }
        public long? ArrivalId { get; set; }
        public short? ShippingId { get; set; }
        public int? ShippingLineId { get; set; }
        public int? Containerunwire { get; set; }
        public int? ContainerWire { get; set; }
    }
}
