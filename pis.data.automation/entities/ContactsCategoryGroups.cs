using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class ContactsCategoryGroups
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
