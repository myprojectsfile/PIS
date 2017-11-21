using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngSendAgain
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public int RequesterUserId { get; set; }
        public int RequesterRoleId { get; set; }
        public DateTime RequestDate { get; set; }

        public EmailMngSends Send { get; set; }
    }
}
