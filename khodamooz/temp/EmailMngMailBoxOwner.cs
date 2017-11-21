using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngMailBoxOwner
    {
        public EmailMngMailBoxOwner()
        {
            EmailMngMailBoxOwnerRel = new HashSet<EmailMngMailBoxOwnerRel>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string OwnerType { get; set; }
        public int OwnerId { get; set; }
        public bool? Active { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public int? LastEditorUserId { get; set; }
        public int? LastEditorRoleId { get; set; }
        public string Crc { get; set; }

        public ICollection<EmailMngMailBoxOwnerRel> EmailMngMailBoxOwnerRel { get; set; }
    }
}
