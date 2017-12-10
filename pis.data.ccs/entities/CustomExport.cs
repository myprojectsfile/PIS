using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CustomExport
    {
        public long CustomId { get; set; }
        public string CustomPermission { get; set; }
        public DateTime? CustomPermissionDate { get; set; }
        public long? Shipper { get; set; }
        public string Sezletter { get; set; }
        public string CustomDischareNo { get; set; }
        public string BillingNo { get; set; }
        public string SourceCustom { get; set; }
        public string Description { get; set; }
        public string TrackingNo { get; set; }
        public long? Declarator { get; set; }
        public long? CustomType { get; set; }
        public short? OperatorId { get; set; }
        public bool? Cancel { get; set; }

        public Cargo Cargo { get; set; }
    }
}
