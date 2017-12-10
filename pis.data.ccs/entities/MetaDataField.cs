using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MetaDataField
    {
        public int MetaDataFieldId { get; set; }
        public string MetaDataFieldFarsi { get; set; }
        public string MetaDataFieldLatin { get; set; }
        public int? MetaDataTableId { get; set; }
    }
}
