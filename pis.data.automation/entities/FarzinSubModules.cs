using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FarzinSubModules
    {
        public int FarzinSubModuleId { get; set; }
        public int FarzinModuleId { get; set; }
        public string FarzinSubModuleName { get; set; }
        public bool? IsActiveForDataValidation { get; set; }
    }
}
