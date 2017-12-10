using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class HazardousCode
    {
        public HazardousCode()
        {
            AddedContainer = new HashSet<AddedContainer>();
            CargoType = new HashSet<CargoType>();
        }

        public string HazardousCode1 { get; set; }
        public string Name { get; set; }

        public ICollection<AddedContainer> AddedContainer { get; set; }
        public ICollection<CargoType> CargoType { get; set; }
    }
}
