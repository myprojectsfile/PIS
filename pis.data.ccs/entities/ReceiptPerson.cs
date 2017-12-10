using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ReceiptPerson
    {
        public long PersonReceiptId { get; set; }
        public long ReceiptId { get; set; }
        public long PersonId { get; set; }
        public byte? Status { get; set; }
        public long? OldPersonId { get; set; }

        public Persons Person { get; set; }
        public Receipt Receipt { get; set; }
    }
}
