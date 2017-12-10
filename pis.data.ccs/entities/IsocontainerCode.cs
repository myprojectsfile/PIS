using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class IsocontainerCode
    {
        public IsocontainerCode()
        {
            Container = new HashSet<Container>();
            ContainerHistory = new HashSet<ContainerHistory>();
        }

        public int IsocontainerCode1 { get; set; }
        public byte ContainerType { get; set; }
        public byte ContainerSize { get; set; }

        public ContainerType ContainerTypeNavigation { get; set; }
        public ICollection<Container> Container { get; set; }
        public ICollection<ContainerHistory> ContainerHistory { get; set; }
    }
}
