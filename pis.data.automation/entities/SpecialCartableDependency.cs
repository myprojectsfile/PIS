using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class SpecialCartableDependency
    {
        public int Id { get; set; }
        public int SpecialCartableId { get; set; }
        public int DependencyCategory { get; set; }
        public int DependencyId { get; set; }
        public int DependencyType { get; set; }
        public int? DependencyPriority { get; set; }
        public bool? IsHighlight { get; set; }
        public string StickyNote { get; set; }
    }
}
