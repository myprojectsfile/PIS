﻿using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityIncidentMngNewVersian
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
        public string IncidentType { get; set; }
        public int? AssetType { get; set; }
        public string AssetName { get; set; }
        public DateTime? IdentifyDate { get; set; }
        public string IncidentDiscription { get; set; }
        public string ReporterName { get; set; }
        public int? Impressment { get; set; }
        public int? Urgency { get; set; }
        public int? IncidentPriority { get; set; }
        public string IncidentFrequency { get; set; }
        public string FrequencyDetail { get; set; }
        public DateTime? MoratoriumTime { get; set; }
        public string FunctorName { get; set; }
        public string BasisReason { get; set; }
        public string ActionDesription { get; set; }
        public string ActionPelan { get; set; }
        public string SolvingTime { get; set; }
        public int? IncidentStatus { get; set; }
        public string Resolution { get; set; }
        public string SuccessBcp { get; set; }
        public string CommitteeReport { get; set; }
        public string ResponsibleAction { get; set; }
        public DateTime? ReviewDate { get; set; }
        public DateTime? ActionTimeout { get; set; }
        public DateTime? LetterDoc { get; set; }
    }
}
