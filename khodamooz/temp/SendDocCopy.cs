using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SendDocCopy
    {
        public int CopyId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string ReceiverName { get; set; }
        public DateTime CreationDate { get; set; }
        public int? ActionCode { get; set; }
        public int? DepartmentId { get; set; }
        public int? OrganizationId { get; set; }
        public int? RoleId { get; set; }
        public int? CreationRoleId { get; set; }
    }
}
