using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityRegistry
    {
        public int RegistryCode { get; set; }
        public string EntityTypeName { get; set; }
        public int? EntityTypeCode { get; set; }
        public int? EntityCode { get; set; }
        public string EntityTitle { get; set; }
        public string EntityNumber { get; set; }
        public string ImportEntityNumber { get; set; }
        public string ExportEntityNumber { get; set; }
        public bool? Deleted { get; set; }
    }
}
