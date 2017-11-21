using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityDataTypes
    {
        public int DataTypeCode { get; set; }
        public string EnglishName { get; set; }
        public string FarsiName { get; set; }
        public int MaxLength { get; set; }
        public bool FixedLength { get; set; }
        public bool OriginalType { get; set; }
        public int? ParentCode { get; set; }
        public bool? AllowNull { get; set; }
        public string RelatedTable { get; set; }
        public string RelatedFields { get; set; }
        public bool? SpecialType { get; set; }
        public bool? Related { get; set; }
        public bool? OtherIsAvailable { get; set; }
        public string Description { get; set; }
        public int? PriorityId { get; set; }
    }
}
