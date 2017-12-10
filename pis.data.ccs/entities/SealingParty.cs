using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class SealingParty
    {
        public SealingParty()
        {
            AddedContainer = new HashSet<AddedContainer>();
            Container = new HashSet<Container>();
        }

        public string SealingPartyCode { get; set; }
        public string Name { get; set; }

        public ICollection<AddedContainer> AddedContainer { get; set; }
        public ICollection<Container> Container { get; set; }
    }
}
