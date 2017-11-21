using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class WfstructureVersion
    {
        public int WfversionId { get; set; }
        public int? Wfid { get; set; }
        public string WfstructureXml { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
