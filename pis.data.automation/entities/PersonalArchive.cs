using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class PersonalArchive
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public int ParentId { get; set; }
        public int RoleId { get; set; }
    }
}
