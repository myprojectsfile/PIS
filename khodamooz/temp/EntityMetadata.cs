using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityMetadata
    {
        public EntityMetadata()
        {
            EntityView = new HashSet<EntityView>();
        }

        public int EntityTypeCode { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeFarsiName { get; set; }
        public string IconName { get; set; }
        public string PictureTemplateAppName { get; set; }
        public string TemplateProperty { get; set; }
        public DateTime CreationDate { get; set; }
        public string FieldsNames { get; set; }
        public string BriefCitationFields { get; set; }
        public string FullCitationFields { get; set; }
        public string DataEntryFields { get; set; }
        public string EntityTitleField { get; set; }
        public string IndexFields { get; set; }
        public string SimpleSearchFields { get; set; }
        public string AdvancedSearchMap { get; set; }
        public int? LanguageCode { get; set; }
        public string EntityNumberRule { get; set; }
        public bool IsOnline { get; set; }
        public bool IsEditable { get; set; }
        public DateTime? ViewAfterDate { get; set; }
        public string EntityAbrName { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int? MultiCategoryId { get; set; }
        public string Keywords { get; set; }
        public int EntityNumberIdentity { get; set; }
        public short StepEntityNumber { get; set; }
        public string AccessControl { get; set; }
        public short FormType { get; set; }
        public string RelatedFieldsXml { get; set; }
        public string Htmltemplate { get; set; }
        public string WorkFlowNames { get; set; }
        public string RelatedServices { get; set; }
        public string FormTypeSetting { get; set; }

        public ICollection<EntityView> EntityView { get; set; }
    }
}
