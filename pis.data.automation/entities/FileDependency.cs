using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FileDependency
    {
        public int DependencyId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string FileName { get; set; }
        public short DependencyType { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? ModifyFlag { get; set; }
    }
}
