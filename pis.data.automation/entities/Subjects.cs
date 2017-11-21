using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Subjects
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public string SubjectCode { get; set; }
        public int CategoryId { get; set; }
        public int? IndicatorId { get; set; }
    }
}
