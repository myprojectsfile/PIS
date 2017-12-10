using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ArrivalNotice
    {
        public ArrivalNotice()
        {
            ArrivalOperator = new HashSet<ArrivalOperator>();
            SlotSharing = new HashSet<SlotSharing>();
        }

        public long Id { get; set; }
        public DateTime? Eta { get; set; }
        public string VoyageNumberImp { get; set; }
        public string VesselName { get; set; }
        public string Imo { get; set; }
        public short? ShippingParentId { get; set; }
        public string VoyageNumberDep { get; set; }
        public string OriginPort { get; set; }
        public string LastPort { get; set; }
        public string NextPort { get; set; }
        public string DestPort { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public int? Dgcargo { get; set; }
        public int? Ogcargo { get; set; }
        public string Remark { get; set; }
        public int? Rfcargo { get; set; }
        public string Rotation { get; set; }
        public bool? Status { get; set; }
        public long? TotEstDis { get; set; }
        public long? TotEstLoad { get; set; }
        public long? TotEstShift { get; set; }
        public string VoyageType { get; set; }
        public long? TotEstDisTeu { get; set; }
        public long? TotEstLoadTeu { get; set; }
        public long? TotEstShiftTeu { get; set; }
        public string BookingNumber { get; set; }
        public bool? IsSettled { get; set; }
        public decimal? ArrivalNorm { get; set; }
        public decimal? DischargeNorm { get; set; }
        public decimal? LoadingNorm { get; set; }

        public ArrivalDetails ArrivalDetails { get; set; }
        public ICollection<ArrivalOperator> ArrivalOperator { get; set; }
        public ICollection<SlotSharing> SlotSharing { get; set; }
    }
}
