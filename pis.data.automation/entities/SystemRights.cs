using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SystemRights
    {
        public int RightId { get; set; }
        public string RightName { get; set; }
        public string RelatedService { get; set; }
        public short RightType { get; set; }
        public string IsConfirmable { get; set; }
        public int? Etc { get; set; }
        public int? OrganizationRoleId { get; set; }
        public int? ReportCategoryCode { get; set; }
        public int? ItemId { get; set; }
    }
}
