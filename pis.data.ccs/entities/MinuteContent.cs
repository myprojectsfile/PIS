using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MinuteContent
    {
        public long MinuteId { get; set; }
        public long ContainerId { get; set; }
        public DateTime? Date { get; set; }
        public int? NumberOfnegleReal { get; set; }
        public int? NumberOfNegleDischarged { get; set; }
        public int? NumberOfNegleManifest { get; set; }
        public short? MinuteContentStatus { get; set; }
    }
}
