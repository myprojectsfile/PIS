using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ContainerType
    {
        public ContainerType()
        {
            AddedContainer = new HashSet<AddedContainer>();
            DischargeTally = new HashSet<DischargeTally>();
            IsocontainerCode = new HashSet<IsocontainerCode>();
        }

        public byte ContainerTypeCode { get; set; }
        public string Description { get; set; }

        public ICollection<AddedContainer> AddedContainer { get; set; }
        public ICollection<DischargeTally> DischargeTally { get; set; }
        public ICollection<IsocontainerCode> IsocontainerCode { get; set; }
    }
}
