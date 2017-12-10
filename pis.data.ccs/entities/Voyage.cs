using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Voyage
    {
        public Voyage()
        {
            Bl = new HashSet<Bl>();
            DischargeList = new HashSet<DischargeList>();
            ManifestCorrection = new HashSet<ManifestCorrection>();
            ReceiptCnt = new HashSet<ReceiptCnt>();
        }

        public long VoyageId { get; set; }
        public string VoyageNumber { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? BerthTime { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string ShippingLine { get; set; }
        public string ShippingAgent { get; set; }
        public string VesselName { get; set; }
        public bool VesselType { get; set; }
        public string Nationality { get; set; }
        public string PortOfLoadingId { get; set; }
        public string PortOfDischargeId { get; set; }
        public DateTime Eta { get; set; }
        public DateTime Etd { get; set; }
        public short? ShippingId { get; set; }
        public string BookingNumber { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsFinalize { get; set; }
        public long? TripId { get; set; }
        public long? TypeId { get; set; }
        public DateTime? DateModifyVoyage { get; set; }
        public bool? IsOpen { get; set; }
        public decimal? OverTime { get; set; }
        public bool? UseCraine { get; set; }

        public Country NationalityNavigation { get; set; }
        public ICollection<Bl> Bl { get; set; }
        public ICollection<DischargeList> DischargeList { get; set; }
        public ICollection<ManifestCorrection> ManifestCorrection { get; set; }
        public ICollection<ReceiptCnt> ReceiptCnt { get; set; }
    }
}
