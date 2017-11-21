using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class MsgReceivers
    {
        public int MsgId { get; set; }
        public int ReceiverUserId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime? ViewDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ReceiveRemoveDate { get; set; }
        public int? ReceiverRoleId { get; set; }

        public MsgSents Msg { get; set; }
    }
}
