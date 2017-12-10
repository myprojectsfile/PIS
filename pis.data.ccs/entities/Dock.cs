using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Dock
    {
        public Dock()
        {
            Station = new HashSet<Station>();
        }

        public short Id { get; set; }
        public string PortCode { get; set; }
        public string DockName { get; set; }
        public short DockValue { get; set; }

        public ICollection<Station> Station { get; set; }
    }
}
