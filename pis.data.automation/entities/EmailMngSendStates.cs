using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngSendStates
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public string State { get; set; }
        public int ChangerUserId { get; set; }
        public int ChangerRoleId { get; set; }
        public DateTime ChangeDate { get; set; }

        public EmailMngSends Send { get; set; }
    }
}
