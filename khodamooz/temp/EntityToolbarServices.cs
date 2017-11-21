using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityToolbarServices
    {
        public int ServiceId { get; set; }
        public int EntityTypeCode { get; set; }
        public string ToolbarType { get; set; }
        public string EnServiceName { get; set; }
        public string FnServiceName { get; set; }
        public string ViewName { get; set; }
        public string ProcessType { get; set; }
        public int? CreatorRoleId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
