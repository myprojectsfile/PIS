using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class LoadingList
    {
        public LoadingList()
        {
            LoadingTally = new HashSet<LoadingTally>();
        }

        public long LoadingListId { get; set; }
        public string VoyageNumber { get; set; }
        public string VesselName { get; set; }

        public ICollection<LoadingTally> LoadingTally { get; set; }
    }
}
