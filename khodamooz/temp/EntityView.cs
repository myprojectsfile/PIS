using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityView
    {
        public int ViewCode { get; set; }
        public int EntityTypeCode { get; set; }
        public string FieldName { get; set; }
        public bool ValueOrLabel { get; set; }
        public string StyleXml { get; set; }
        public string PropertiesXml { get; set; }
        public string ViewName { get; set; }

        public EntityMetadata EntityTypeCodeNavigation { get; set; }
    }
}
