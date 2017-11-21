using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class DepartmentNews
    {
        public int DepartmentNewsId { get; set; }
        public int? Etc { get; set; }
        public int? Ec { get; set; }
        public DateTime? CreateOrUpdateDate { get; set; }
    }
}
