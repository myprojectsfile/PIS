using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngMailBoxReceiveTrying
    {
        public int Id { get; set; }
        public int MailBoxId { get; set; }
        public int TrierUserId { get; set; }
        public int TrierRoleId { get; set; }
        public string TryType { get; set; }
        public string ViewResult { get; set; }
        public string TechnicalResult { get; set; }
        public DateTime TryDate { get; set; }

        public EmailMngMailBox MailBox { get; set; }
    }
}
