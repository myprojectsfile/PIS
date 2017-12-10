using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class AddedBl
    {
        public string Blnumber { get; set; }
        public string GoodsDescription { get; set; }
        public string Shipper { get; set; }
        public string Notify { get; set; }
        public string Consignee { get; set; }
        public byte EntryType { get; set; }
        public long VoyageId { get; set; }
        public string OldBlnumber { get; set; }
        public string PackagesType { get; set; }
        public Guid Id { get; set; }
        public Guid CorrectionId { get; set; }
        public short? ShippingId { get; set; }
        public long? SlotId { get; set; }
        public bool? IsFullTally { get; set; }
        public string Hscode { get; set; }
        public byte? TransportType { get; set; }

        public ManifestCorrection Correction { get; set; }
    }
}
