using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FarzinInputsRegistry
    {
        public int FarzinInputId { get; set; }
        public int FarzinPageId { get; set; }
        public string Htmltype { get; set; }
        public string RunAt { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string DataType { get; set; }
        public int? DataLen { get; set; }
        public string DataConstraints { get; set; }
        public bool? IsActiveForDataValidation { get; set; }
    }
}
