using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ContentTally
    {
        public long TallyId { get; set; }
        public long VoyageId { get; set; }
        public string ContainerNumber { get; set; }
        public string Blnumber { get; set; }
        public int PackagesCount { get; set; }
        public DateTime Date { get; set; }
        public string Clerk { get; set; }
    }
}
