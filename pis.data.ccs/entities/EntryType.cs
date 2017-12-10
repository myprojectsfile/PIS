using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class EntryType
    {
        public EntryType()
        {
            Bl = new HashSet<Bl>();
        }

        public byte BlnaturalCode { get; set; }
        public string Name { get; set; }
        public byte? Tctscode { get; set; }
        public int? ExportCode { get; set; }

        public ICollection<Bl> Bl { get; set; }
    }
}
