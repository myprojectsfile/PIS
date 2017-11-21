using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class MultiCategory
    {
        public int MultiCategoryId { get; set; }
        public string MultiCategoryName { get; set; }
        public string MultiCategoryDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public int ParentId { get; set; }
    }
}
