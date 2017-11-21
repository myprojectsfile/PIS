using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SubjectCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public int ParentId { get; set; }
    }
}
