using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class DealingReceipt
    {
        public long DealingReceiptId { get; set; }
        public long ReceiptId { get; set; }
        public string Seller { get; set; }
        public string SellerCode { get; set; }
        public string SellerAddress { get; set; }
        public decimal Cost { get; set; }
        public string FactorNumber { get; set; }
        public string Buyer { get; set; }
        public long? OldReceiptId { get; set; }

        public Receipt Receipt { get; set; }
    }
}
