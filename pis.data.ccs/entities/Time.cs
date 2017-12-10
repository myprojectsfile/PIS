using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Time
    {
        public int Id { get; set; }
        public DateTime? Time1 { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string Type { get; set; }
    }
}
