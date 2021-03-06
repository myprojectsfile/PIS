﻿using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityExecuteForm
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
        public string DocNum { get; set; }
        public DateTime? Date1 { get; set; }
        public string Request { get; set; }
        public string Execute { get; set; }
        public string Eghdam4 { get; set; }
        public bool? Yes1 { get; set; }
        public bool? Yes2 { get; set; }
        public bool? Yes3 { get; set; }
        public bool? Yes4 { get; set; }
        public string ExplainProblem1 { get; set; }
        public string Name { get; set; }
        public string MoreExplain { get; set; }
        public string Eghdam5 { get; set; }
        public string Eghdam6 { get; set; }
        public string Eghdam7 { get; set; }
        public string Eghdam8 { get; set; }
        public bool? Effective1 { get; set; }
        public bool? Effective2 { get; set; }
        public bool? Effective3 { get; set; }
        public bool? Effective4 { get; set; }
        public bool? NonEffective1 { get; set; }
        public bool? NonEffective2 { get; set; }
        public bool? NonEffective3 { get; set; }
        public bool? NonEffective4 { get; set; }
        public string Explain1 { get; set; }
        public string Explain2 { get; set; }
        public string Explain3 { get; set; }
        public string Explain4 { get; set; }
        public string ExplainProblem2 { get; set; }
        public string ExplainProblem3 { get; set; }
        public string ExplainProblem4 { get; set; }
        public string Complete { get; set; }
        public DateTime? Date2 { get; set; }
        public bool? No1 { get; set; }
        public bool? No2 { get; set; }
        public bool? No3 { get; set; }
        public bool? No4 { get; set; }
        public DateTime? Date3 { get; set; }
        public string Tittle { get; set; }
    }
}
