using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class ArchiveFolderPermission
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public int? RoleId { get; set; }
        public int? GroupId { get; set; }
        public short? PolicyTypeId { get; set; }
    }
}
