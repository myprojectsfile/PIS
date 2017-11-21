using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class LayoutJob
    {
        public int JobId { get; set; }
        public int? JobType { get; set; }
        public int? ItemId { get; set; }
        public int? LayoutId { get; set; }
        public string JobStructure { get; set; }
        public string JobResult { get; set; }
        public int? JobState { get; set; }
        public int? InvalidTry { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int Priority { get; set; }
    }
}
