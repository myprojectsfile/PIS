using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class ArchiveDepartment
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Code { get; set; }
        public string SubjectDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public int ParentId { get; set; }
        public int OrganizationId { get; set; }
        public int DepartmentId { get; set; }
        public short? OtherPolicyTypeId { get; set; }
        public string ArchiveLocation { get; set; }
    }
}
