using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class ActiveSends
    {
        public ActiveSends()
        {
            ActiveSendReceivers = new HashSet<ActiveSendReceivers>();
        }

        public int SendCode { get; set; }
        public int SenderRoleId { get; set; }
        public int? SenderId { get; set; }
        public int EntityTypeCode { get; set; }
        public int EntityCode { get; set; }
        public DateTime SendDate { get; set; }
        public int SendParentCode { get; set; }
        public int ParentReceiverCode { get; set; }
        public bool SendType { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool? SendIsRecycle { get; set; }
        public DateTime? SendRecycleDate { get; set; }
        public bool? SendIsDeleted { get; set; }
        public string SendRecycleRefrence { get; set; }
        public bool? ViewInOutbox { get; set; }
        public int? WfexecutionId { get; set; }

        public ICollection<ActiveSendReceivers> ActiveSendReceivers { get; set; }
    }
}
