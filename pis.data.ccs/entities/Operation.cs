using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Operation
    {
        public Operation()
        {
            Event = new HashSet<Event>();
            GroupPermission = new HashSet<GroupPermission>();
            PagePermission = new HashSet<PagePermission>();
        }

        public int OperationId { get; set; }
        public string OperationNameEn { get; set; }
        public short CategoryId { get; set; }
        public string OperationNameFa { get; set; }

        public ICollection<Event> Event { get; set; }
        public ICollection<GroupPermission> GroupPermission { get; set; }
        public ICollection<PagePermission> PagePermission { get; set; }
    }
}
