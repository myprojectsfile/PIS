﻿using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityRequestForm1
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
        public string ProcessRequest { get; set; }
        public string Tittle { get; set; }
        public bool? MangQuality { get; set; }
        public bool? MangEnvironment { get; set; }
        public bool? MangeSafety { get; set; }
        public bool? Eslah { get; set; }
        public bool? Pishgiri { get; set; }
        public bool? Behbod { get; set; }
        public string Explanation { get; set; }
        public string Reason { get; set; }
        public string NameRequest { get; set; }
        public string OpinionAssistant { get; set; }
        public string NameAssistant { get; set; }
        public bool? SendProcess { get; set; }
        public string Process { get; set; }
        public bool? Yes { get; set; }
        public bool? No { get; set; }
        public string OpinionSupporter { get; set; }
        public bool? Yes1 { get; set; }
        public bool? No1 { get; set; }
        public string OpinionManager { get; set; }
        public string RuleSupporter { get; set; }
        public string ReasonMoghayerat { get; set; }
        public string Num1 { get; set; }
        public string Peak1 { get; set; }
        public string Pursuit1 { get; set; }
        public DateTime? Date { get; set; }
    }
}
