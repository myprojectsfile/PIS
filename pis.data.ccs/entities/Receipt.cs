using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Receipt
    {
        public Receipt()
        {
            ReceiptPerson = new HashSet<ReceiptPerson>();
        }

        public long ReceiptId { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime Date { get; set; }
        public string Serial { get; set; }
        public long Blid { get; set; }
        public string Deliverer { get; set; }
        public string Declarator { get; set; }
        public string Donumber { get; set; }
        public string Lcnumber { get; set; }
        public string IssuedBy { get; set; }
        public bool Cancel { get; set; }
        public long? VoyageId { get; set; }
        public DateTime? DischargeDate { get; set; }
        public long? Status { get; set; }
        public long? ReceiptParentId { get; set; }
        public long? ReceiptType { get; set; }
        public long? ToOrderId { get; set; }
        public int? PrintCount { get; set; }
        public int? PrintPermissionCount { get; set; }
        public int? PrintShippingCount { get; set; }
        public long? BuyerId { get; set; }

        public Types StatusNavigation { get; set; }
        public DealingReceipt DealingReceipt { get; set; }
        public ICollection<ReceiptPerson> ReceiptPerson { get; set; }
    }
}
