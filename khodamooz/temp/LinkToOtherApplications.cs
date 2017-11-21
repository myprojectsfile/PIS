using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class LinkToOtherApplications
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public string AppAddress { get; set; }
        public string AppType { get; set; }
        public string OpenType { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
