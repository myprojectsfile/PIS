using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SpecialCartableSecretaryPersonnel
    {
        public int Id { get; set; }
        public int ManagerRoleId { get; set; }
        public int ManagerUserId { get; set; }
        public int SecretaryRoleId { get; set; }
        public int SecretaryUserId { get; set; }
        public string ActionCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatorRoleId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatorIp { get; set; }
    }
}
