using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ExportBl
    {
        public long Eblid { get; set; }
        public string Eblnumber { get; set; }
        public string Consignee { get; set; }
        public string DecarantName { get; set; }
        public string DestinationPortName { get; set; }
        public DateTime IssuanceDate { get; set; }
        public string Notify { get; set; }
        public string BillingNo { get; set; }
        public string CustomDischareNo { get; set; }
        public string CustomPermission { get; set; }
        public DateTime? CustomPermissionDate { get; set; }
        public string Sezletter { get; set; }
        public long? Shipper { get; set; }
        public string SourceCustom { get; set; }
    }
}
