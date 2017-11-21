using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class ContactsGroupMember
    {
        public int Id { get; set; }
        public int? CotactsId { get; set; }
        public int? GroupId { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
