using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class ContactsCategoryGroups
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
