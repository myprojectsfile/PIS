using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ThctarrifMain
    {
        public int Mtid { get; set; }
        public string Mtname { get; set; }
        public string Mtdescription { get; set; }
        public DateTime? MttoDate { get; set; }
        public DateTime? MtfromDate { get; set; }
        public bool? Mtstatus { get; set; }
    }
}
