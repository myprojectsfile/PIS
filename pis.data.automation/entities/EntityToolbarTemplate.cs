using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityToolbarTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string CartableUpdateMode { get; set; }
        public string CartableViewMode { get; set; }
        public string OtherViewMode { get; set; }
        public string OtherUpdateMode { get; set; }
        public string CartableUpdateModeTheme { get; set; }
        public string CartableViewModeTheme { get; set; }
        public string OtherViewModeTheme { get; set; }
        public string OtherUpdateModeTheme { get; set; }
        public DateTime CreationDate { get; set; }
        public string SpecialCartableUpdateMode { get; set; }
        public string SpecialCartableViewMode { get; set; }
        public string SpecialCartableUpdateModeTheme { get; set; }
        public string SpecialCartableViewModeTheme { get; set; }
    }
}
