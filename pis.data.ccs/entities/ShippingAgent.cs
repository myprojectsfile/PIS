using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ShippingAgent
    {
        public short ShippingId { get; set; }
        public int UserId { get; set; }

        public Shipping Shipping { get; set; }
        public User User { get; set; }
    }
}
