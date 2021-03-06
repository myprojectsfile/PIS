﻿using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityPeriodicReviewChecklistServerForm
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
        public string Title { get; set; }
        public bool? Row1Item1 { get; set; }
        public bool? Row1Item2 { get; set; }
        public bool? Row1Item3 { get; set; }
        public bool? Row1Item4 { get; set; }
        public string PeriodRow1 { get; set; }
        public string VisitorRow1 { get; set; }
        public bool? Row2Item1 { get; set; }
        public bool? Row2Item2 { get; set; }
        public bool? Row2Item3 { get; set; }
        public bool? Row2Item4 { get; set; }
        public string PeriodRow2 { get; set; }
        public string VisitorRow2 { get; set; }
        public bool? Row3Item1 { get; set; }
        public bool? Row3Item2 { get; set; }
        public string PeriodRow3 { get; set; }
        public string VisitorRow3 { get; set; }
        public bool? Row4Item1 { get; set; }
        public bool? Row4Item2 { get; set; }
        public bool? Row4Item3 { get; set; }
        public string PeriodRow4 { get; set; }
        public string VisitorRow4 { get; set; }
        public bool? Row5 { get; set; }
        public string PeriodRow5 { get; set; }
        public string VisitorRow5 { get; set; }
        public bool? Row6 { get; set; }
        public string PeriodRow6 { get; set; }
        public string VisitorRow6 { get; set; }
        public bool? Row7Item1 { get; set; }
        public bool? Row7Item2 { get; set; }
        public bool? Row7Item3 { get; set; }
        public string PeriodRow7 { get; set; }
        public string VisitorRow7 { get; set; }
        public string NetAdmin { get; set; }
        public string Nazer { get; set; }
        public string BossInformatic { get; set; }
        public DateTime? LetterDate { get; set; }
        public string NetAdminDes { get; set; }
        public string SupervisorDes { get; set; }
        public string NetExpertDes { get; set; }
        public string CompanyDes { get; set; }
    }
}
