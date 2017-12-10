using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Ccsconfig
    {
        public long ConfigId { get; set; }
        public string FaName { get; set; }
        public string EnName { get; set; }
        public string Value { get; set; }
        public long? CreateDate { get; set; }
        public string ProName { get; set; }
    }
}
