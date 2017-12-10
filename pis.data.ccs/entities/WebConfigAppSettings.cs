using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class WebConfigAppSettings
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
