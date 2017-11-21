using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class InternalReceivers
    {
        public int InternalReceiverId { get; set; }
        public int EntityTypeCode { get; set; }
        public int EntityCode { get; set; }
        public int? ReceiverRoleId { get; set; }
        public int? ActionCode { get; set; }
        public string HameshTitle { get; set; }
        public string HameshContent { get; set; }
        public string Description { get; set; }
        public bool? IsLocked { get; set; }
        public int? ViewInOutbox { get; set; }
        public int? ResponseUntilDay { get; set; }
        public int? ResponseUntilHour { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreatorRoleId { get; set; }
        public bool? IsSend { get; set; }
        public int? SendCode { get; set; }
        public string ExtendedField { get; set; }
    }
}
