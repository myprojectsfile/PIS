using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityPurchaseHardwareEquipmentForm
    {
        public int EntityCode { get; set; }
        public int CategoryCode { get; set; }
        public int RaitingHits { get; set; }
        public int? Grade { get; set; }
        public bool? IsPreNote { get; set; }
        public bool Locked { get; set; }
        public bool LocalLock { get; set; }
        public int LocalLockUserCode { get; set; }
        public int LocalLockRoleId { get; set; }
        public int LockUserCode { get; set; }
        public int LockRoleId { get; set; }
        public string FieldsStatus { get; set; }
        public bool IsPrivateSearch { get; set; }
        public int PrivateSearchUserCode { get; set; }
        public int PrivateSearchRoleId { get; set; }
        public DateTime? LastSignatureDate { get; set; }
        public string EntityNumber { get; set; }
        public int NumberOfCopies { get; set; }
        public string Version { get; set; }
        public int OriginalVersionCode { get; set; }
        public bool IsSigned { get; set; }
        public int SecurityLevelCode { get; set; }
        public bool? IsConfirm { get; set; }
        public bool? IsActive { get; set; }
        public int FirstEntityCode { get; set; }
        public string From { get; set; }
        public string ImportEntityNumber { get; set; }
        public DateTime? ImportDate { get; set; }
        public string ImportMethod { get; set; }
        public string ImportDesc { get; set; }
        public string ImportOriginNo { get; set; }
        public DateTime? ImportOriginDate { get; set; }
        public string NopgAttached { get; set; }
        public string To { get; set; }
        public string ExportEntityNumber { get; set; }
        public DateTime? ExportDate { get; set; }
        public string ExportMethod { get; set; }
        public string ExportDesc { get; set; }
        public int? ImportIndicatorId { get; set; }
        public int? ExportIndicatorId { get; set; }
        public int? ImportRegisterId { get; set; }
        public int? ImportRegisterRoleId { get; set; }
        public int? ExportRegisterId { get; set; }
        public int? ExportRegisterRoleId { get; set; }
        public string DocType { get; set; }
        public string DocSubject { get; set; }
        public string DocKeywords { get; set; }
        public int? Priority { get; set; }
        public int? ImportPriority { get; set; }
        public int? ExportPriority { get; set; }
        public int CreatorId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public string DeviceName { get; set; }
        public string DeviceTotal { get; set; }
        public string ApplicationType { get; set; }
        public string Group { get; set; }
        public string Cast { get; set; }
        public string Budget { get; set; }
        public bool? BusinessSmall { get; set; }
        public bool? BusinessMedium { get; set; }
        public bool? BusinessLarge { get; set; }
        public string StatusDescription { get; set; }
        public string CapabilityDevice { get; set; }
        public string SpecificitySecurity { get; set; }
        public string ImprovementEffect { get; set; }
        public bool? DependenceYes { get; set; }
        public bool? DependenceNo { get; set; }
        public string DependenceDes { get; set; }
        public bool? SpecializationYes { get; set; }
        public bool? SpecializationNo { get; set; }
        public string SpecializationDes { get; set; }
        public bool? FutureExpectationYes { get; set; }
        public bool? FutureExpectationsNo { get; set; }
        public string FutureExpectationsDes { get; set; }
        public string TechnicalSpecifications { get; set; }
        public bool? AttachBuy { get; set; }
        public bool? AttachTechnical { get; set; }
        public bool? AttachTender { get; set; }
        public string FeforrtRole { get; set; }
        public string FbVerifyRole { get; set; }
        public string FverifySign { get; set; }
        public string FberifySign { get; set; }
        public DateTime? LettetDoc { get; set; }
    }
}
