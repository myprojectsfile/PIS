using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Uipage
    {
        public Uipage()
        {
            PagePermission = new HashSet<PagePermission>();
        }

        public short Id { get; set; }
        public string Url { get; set; }
        public bool Backend { get; set; }

        public ICollection<PagePermission> PagePermission { get; set; }
    }
}
