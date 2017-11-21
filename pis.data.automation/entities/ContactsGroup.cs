using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class ContactsGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short? Type { get; set; }
        public string Note { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
