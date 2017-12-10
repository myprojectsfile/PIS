using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MovementType
    {
        public MovementType()
        {
            AddedContainer = new HashSet<AddedContainer>();
            Container = new HashSet<Container>();
        }

        public byte MoveId { get; set; }
        public string Name { get; set; }

        public ICollection<AddedContainer> AddedContainer { get; set; }
        public ICollection<Container> Container { get; set; }
    }
}
