using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ManifestCorrection
    {
        public ManifestCorrection()
        {
            AddedBl = new HashSet<AddedBl>();
            AddedContainer = new HashSet<AddedContainer>();
            ManifestCorrectionDetail = new HashSet<ManifestCorrectionDetail>();
            ManifestLinkCorrection = new HashSet<ManifestLinkCorrection>();
        }

        public Guid CorrectionId { get; set; }
        public DateTime SentDate { get; set; }
        public int SentBy { get; set; }
        public bool? Approved { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public long VoyageId { get; set; }
        public string BankReceiptNo { get; set; }
        public int? CorrectionReasonId { get; set; }
        public short? ShippingId { get; set; }
        public decimal? BankPrice { get; set; }
        public long? SlotId { get; set; }
        public long? Status { get; set; }

        public User ApprovedByNavigation { get; set; }
        public ManifestCorrectionReason CorrectionReason { get; set; }
        public User SentByNavigation { get; set; }
        public Voyage Voyage { get; set; }
        public ICollection<AddedBl> AddedBl { get; set; }
        public ICollection<AddedContainer> AddedContainer { get; set; }
        public ICollection<ManifestCorrectionDetail> ManifestCorrectionDetail { get; set; }
        public ICollection<ManifestLinkCorrection> ManifestLinkCorrection { get; set; }
    }
}
