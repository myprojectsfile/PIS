using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Rptentity
    {
        public int EntityId { get; set; }
        public int? DbCode { get; set; }
        public string EnglishName { get; set; }
        public string FarsiName { get; set; }
        public string PrimaryKey { get; set; }
        public string Owner { get; set; }
        public string AllFields { get; set; }
        public int? Type { get; set; }
    }
}
