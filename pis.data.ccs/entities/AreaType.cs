using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class AreaType
    {
        public AreaType()
        {
            Area = new HashSet<Area>();
        }

        public short AreaTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Area> Area { get; set; }
    }
}
