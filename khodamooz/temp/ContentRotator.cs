using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class ContentRotator
    {
        public int ContentId { get; set; }
        public string Subject { get; set; }
        public string TxtContentHtml { get; set; }
        public short ShowType { get; set; }
        public byte? DayOfWeek { get; set; }
        public byte? DayOfMonth { get; set; }
        public bool? IsActive { get; set; }
        public bool? EnforceShow { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? EditionDate { get; set; }
        public int? EditorRoleId { get; set; }
    }
}
