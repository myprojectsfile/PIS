using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SpecialCartable
    {
        public int SpecialCartableId { get; set; }
        public int ManagerRoleId { get; set; }
        public int SecretaryRoleId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public int ReceiverCode { get; set; }
        public int CategoryId { get; set; }
        public int? EntityPriority { get; set; }
        public string StickyNote { get; set; }
        public int? CreatorRoleId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatorIp { get; set; }
    }
}
