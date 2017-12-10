using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Domain
    {
        public Domain()
        {
            Types = new HashSet<Types>();
        }

        public long DomainId { get; set; }
        public string DomainKey { get; set; }
        public string DomainFarsi { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDateTime { get; set; }

        public ICollection<Types> Types { get; set; }
    }
}
