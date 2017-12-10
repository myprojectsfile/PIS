using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class AutoGenerateNumbers
    {
        public short Id { get; set; }
        public int? LastValue { get; set; }
        public long? Type { get; set; }
        public string Year { get; set; }
    }
}
