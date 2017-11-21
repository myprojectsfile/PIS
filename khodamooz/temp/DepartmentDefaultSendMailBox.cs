using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class DepartmentDefaultSendMailBox
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int MailBoxId { get; set; }
    }
}
