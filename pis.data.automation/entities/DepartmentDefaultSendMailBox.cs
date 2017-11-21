using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class DepartmentDefaultSendMailBox
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int MailBoxId { get; set; }
    }
}
