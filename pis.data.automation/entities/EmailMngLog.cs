using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngLog
    {
        public int Id { get; set; }
        public string LogAction { get; set; }
        public string LogSection { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Ipaddress { get; set; }
        public string LogMsg { get; set; }
        public DateTime LogDate { get; set; }
    }
}
