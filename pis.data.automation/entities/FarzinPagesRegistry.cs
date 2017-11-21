using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinPagesRegistry
    {
        public int FarzinPageId { get; set; }
        public int FarzinSubModuleId { get; set; }
        public string PagePath { get; set; }
        public bool? IsActiveForDataValidation { get; set; }
        public bool? IsReAuthenticationRequired { get; set; }
        public int? Severity { get; set; }
    }
}
