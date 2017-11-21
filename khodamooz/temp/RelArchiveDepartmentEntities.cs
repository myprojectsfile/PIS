using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class RelArchiveDepartmentEntities
    {
        public int SubjectId { get; set; }
        public int EntityTypeCode { get; set; }
        public int EntityCode { get; set; }
        public DateTime ArchiveTime { get; set; }
        public string ArchiveDescription { get; set; }
        public string EntityNumber { get; set; }
        public string EntityTitle { get; set; }
    }
}
