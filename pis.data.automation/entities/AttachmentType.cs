using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class AttachmentType
    {
        public int AttachmentTypeCode { get; set; }
        public string Title { get; set; }
        public bool? Active { get; set; }
    }
}
