using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngSendTrying
    {
        public int Id { get; set; }
        public int SendId { get; set; }
        public int TrierUserId { get; set; }
        public int TrierRoleId { get; set; }
        public string ViewResult { get; set; }
        public string TechnicalResult { get; set; }
        public DateTime TryDate { get; set; }

        public EmailMngSends Send { get; set; }
    }
}
