using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityCategories
    {
        public int CategoryCode { get; set; }
        public int CategoryEtc { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditionDate { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public bool? IsActive { get; set; }
    }
}
