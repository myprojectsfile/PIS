using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class IndexParameter
    {
        public int Id { get; set; }
        public int IndexId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Required { get; set; }
        public string LableTextFa { get; set; }
        public string LabelTextEn { get; set; }
        public string EnumerationTextFa { get; set; }
        public string EnumerationTextEn { get; set; }
        public bool? IsBounded { get; set; }
        public bool? IsParameter { get; set; }

        public Index Index { get; set; }
    }
}
