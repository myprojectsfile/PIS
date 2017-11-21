using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FicRules
    {
        public int RuleId { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public string RuleName { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ActionCodes { get; set; }
        public string SenderRoleIds { get; set; }
        public string SenderIds { get; set; }
        public string EntityTypeCodes { get; set; }
        public string Priorities { get; set; }
        public string SecurityLevelCodes { get; set; }
        public string EntityTitle { get; set; }
        public string Description { get; set; }
        public string HameshContent { get; set; }
        public string RuleXml { get; set; }
    }
}
