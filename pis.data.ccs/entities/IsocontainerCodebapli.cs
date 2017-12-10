using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class IsocontainerCodebapli
    {
        public string IsocontainerCodeBapli { get; set; }
        public byte ContainerType { get; set; }
        public byte ContainerSize { get; set; }
        public string IsonewCode { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
    }
}
