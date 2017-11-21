using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinCitizenFollowUpCategoryDetails
    {
        public int Trackingcode { get; set; }
        public int CategoryId { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string ServiceNumber { get; set; }
        public string ServiceName { get; set; }
        public string UnitofAction { get; set; }
        public string OrganizationOfAction { get; set; }
        public DateTime ServiceUpdate { get; set; }
        public int? ServiceState { get; set; }
    }
}
