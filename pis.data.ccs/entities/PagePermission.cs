using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class PagePermission
    {
        public int Id { get; set; }
        public short PageId { get; set; }
        public int OperationId { get; set; }

        public Operation Operation { get; set; }
        public Uipage Page { get; set; }
    }
}
