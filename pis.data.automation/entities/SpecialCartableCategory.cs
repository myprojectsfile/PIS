using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SpecialCartableCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ManagerRoleId { get; set; }
        public int? CreatorRoleId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatorIp { get; set; }
    }
}
