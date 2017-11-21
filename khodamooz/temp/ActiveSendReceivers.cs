using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class ActiveSendReceivers
    {
        public int Code { get; set; }
        public int SendCode { get; set; }
        public int ReceiverRoleId { get; set; }
        public int? ReceiverId { get; set; }
        public int? ActionCode { get; set; }
        public string Description { get; set; }
        public DateTime? ResponseUntilDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string ConsiderationType { get; set; }
        public int? ConsiderSendCode { get; set; }
        public int FollowingCount { get; set; }
        public DateTime ReceiveDate { get; set; }
        public bool FinishedOperation { get; set; }
        public bool? ShowRejected { get; set; }
        public string ViewStates { get; set; }
        public DateTime? LastChangeViewStatesDate { get; set; }
        public int? WfscenarioCode { get; set; }
        public string WfextendedParams { get; set; }
        public bool IsHidden { get; set; }
        public int HiddenUserId { get; set; }
        public int HiddenRoleId { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? FirstChangeViewStatesDate { get; set; }

        public ActiveSends SendCodeNavigation { get; set; }
    }
}
