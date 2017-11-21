using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FollowingAgain
    {
        public int FollowingId { get; set; }
        public int SendCode { get; set; }
        public int ReceiverRoleId { get; set; }
        public DateTime? FollowingDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string ViewStates { get; set; }
        public DateTime? LastChangeViewStatesDate { get; set; }
        public DateTime? FirstChangeViewStatesDate { get; set; }
    }
}
