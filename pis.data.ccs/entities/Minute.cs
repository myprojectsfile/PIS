using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Minute
    {
        public Minute()
        {
            MinuteItem = new HashSet<MinuteItem>();
        }

        public long MinuteId { get; set; }
        public long Blid { get; set; }
        public DateTime? Date { get; set; }
        public int? NumberOfnegleReal { get; set; }
        public int? NumberOfNegleDischarged { get; set; }
        public int? NumberOfNegleManifest { get; set; }
        public long? VoyageId { get; set; }
        public short? MinuteStatus { get; set; }
        public bool? MinuteType { get; set; }
        public string MinuteGroup { get; set; }

        public ICollection<MinuteItem> MinuteItem { get; set; }
    }
}
