using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityCorrectivePreventiveActionsIsmsForm
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
        public string AdaptationDes { get; set; }
        public string AdaptationReasonDes { get; set; }
        public string CandPDes1 { get; set; }
        public string CandPDes2 { get; set; }
        public string CandPDes3 { get; set; }
        public string CandPDes4 { get; set; }
        public string Responsible1 { get; set; }
        public string Responsible2 { get; set; }
        public string Responsible3 { get; set; }
        public string Responsible4 { get; set; }
        public string Deadline1 { get; set; }
        public string Deadline2 { get; set; }
        public string Deadline3 { get; set; }
        public string Deadline4 { get; set; }
        public string DescriptionActivity { get; set; }
        public string NonEffectiveReason { get; set; }
        public string FeforrtRole { get; set; }
        public string FbVerifyRole { get; set; }
        public string FverifySign { get; set; }
        public string FberifySign { get; set; }
        public DateTime? LetterDoc { get; set; }
        public string Tiitle { get; set; }
        public bool? Done { get; set; }
        public bool? NotDone { get; set; }
        public bool? Effective { get; set; }
        public bool? NonEffective { get; set; }
        public bool? CorrectiveAction { get; set; }
        public bool? PreventiveAction { get; set; }
        public bool? ProposedImprovement { get; set; }
        public bool? ProcessYes { get; set; }
        public bool? ProcessNo { get; set; }
        public string ProcessExecutive { get; set; }
        public string BossOpinion { get; set; }
    }
}
