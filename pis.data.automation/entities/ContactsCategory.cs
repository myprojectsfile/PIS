using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class ContactsCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryNote { get; set; }
        public int? ParentId { get; set; }
        public short? Type { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
