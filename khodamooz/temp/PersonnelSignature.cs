using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class PersonnelSignature
    {
        public int SignatureId { get; set; }
        public string FilePath { get; set; }
        public int UserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
