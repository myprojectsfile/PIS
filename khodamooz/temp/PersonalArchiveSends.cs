using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class PersonalArchiveSends
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public int SendCode { get; set; }
        public bool IsRecycle { get; set; }
        public DateTime? RecycleDate { get; set; }
        public DateTime ArchiveTime { get; set; }
        public string ArchiveDescription { get; set; }
    }
}
