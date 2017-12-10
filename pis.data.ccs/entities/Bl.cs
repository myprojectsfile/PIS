using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Bl
    {
        public Bl()
        {
            Blcontainer = new HashSet<Blcontainer>();
        }

        public long Blid { get; set; }
        public string Blnumber { get; set; }
        public string GoodsDescription { get; set; }
        public string Shipper { get; set; }
        public string Notify { get; set; }
        public string Consignee { get; set; }
        public byte EntryType { get; set; }
        public long VoyageId { get; set; }
        public short ShippingId { get; set; }
        public string PartNumber { get; set; }
        public string OfficeNumber { get; set; }
        public DateTime? OfficeDate { get; set; }
        public long? SlotId { get; set; }
        public DateTime? DateModifyBl { get; set; }
        public bool? IsFullTally { get; set; }
        public string Hscode { get; set; }
        public byte? TransportType { get; set; }

        public EntryType EntryTypeNavigation { get; set; }
        public Shipping Shipping { get; set; }
        public SlotSharing Slot { get; set; }
        public Voyage Voyage { get; set; }
        public ICollection<Blcontainer> Blcontainer { get; set; }
    }
}
