using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Hamesh
    {
        public int HameshId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserCode { get; set; }
        public int RoleId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Type { get; set; }
        public int? ReceiverCode { get; set; }
        public int? ReceiverRoleId { get; set; }
        public bool? ModifyFlag { get; set; }
        public int? HiddenRoleId { get; set; }
        public int? HiddenUserId { get; set; }
        public bool? IsHidden { get; set; }
    }
}
