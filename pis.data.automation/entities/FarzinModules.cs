using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinModules
    {
        public int FarzinModuleId { get; set; }
        public string FarzinModuleName { get; set; }
        public bool? IsActiveForDataValidation { get; set; }
    }
}
