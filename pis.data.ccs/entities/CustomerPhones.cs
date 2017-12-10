using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CustomerPhones
    {
        public int CustomerId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
    }
}
