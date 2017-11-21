using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinPartnerMapping
    {
        public int Id { get; set; }
        public int IcanId { get; set; }
        public int PartnerId { get; set; }
        public int ItemType { get; set; }
        public int ApplicationId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
