using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FicServices
    {
        public int Id { get; set; }
        public int? RuleId { get; set; }
        public int? Type { get; set; }
        public string Structure { get; set; }
    }
}
