using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class OrganizationRoles
    {
        public int OrganizationRoleId { get; set; }
        public string OrganizationRoleName { get; set; }
        public int? ParentId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsArchive { get; set; }
        public bool IsIndicator { get; set; }
        public int ImportMaxNumber { get; set; }
        public int ExportMaxNumber { get; set; }
        public string ImportFormula { get; set; }
        public string ExportFormula { get; set; }
        public bool IndicatorDependency { get; set; }
        public int ParentDependencyId { get; set; }
        public string PostFixItem { get; set; }
        public string PreFixItem { get; set; }
        public short ImportStep { get; set; }
        public short ExportStep { get; set; }
        public string Code { get; set; }
        public string IndicatorResetConfig { get; set; }
        public short IndicatorNumber { get; set; }
        public bool DefaultIndicator { get; set; }
        public string IndicatorServiceConfig { get; set; }
        public string OrganizationRoleLocation { get; set; }
        public string Title { get; set; }
    }
}
