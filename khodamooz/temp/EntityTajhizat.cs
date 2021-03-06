﻿using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityTajhizat
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
        public string Darkhastkonandeh { get; set; }
        public string Namedastgah { get; set; }
        public string Makanesteghrar { get; set; }
        public string Namesystem { get; set; }
        public DateTime? Tarikh { get; set; }
        public string Sharhemokhtasar { get; set; }
        public string Nazarbahrebardar { get; set; }
        public string Namebahrebardar { get; set; }
        public string Emzabahrebardar { get; set; }
        public string Nazaekarshenas { get; set; }
        public string Shomerehdastoorkar { get; set; }
        public string Peymankar { get; set; }
        public bool? Ezterari { get; set; }
        public string Mohlat { get; set; }
        public bool? Addi { get; set; }
        public string Nazarkarshenasnezarat { get; set; }
        public string Namekarshenasnezarat { get; set; }
        public string Emzakarshenasnezarat { get; set; }
        public string Sharhekar { get; set; }
        public string Nametamirkar1 { get; set; }
        public string Nametamirkar2 { get; set; }
        public string Nametamirkar3 { get; set; }
        public string Nametamirkar4 { get; set; }
        public string Nafarsaat1 { get; set; }
        public string Nafarsaat2 { get; set; }
        public string Nafarsaat3 { get; set; }
        public string Nafarsaat4 { get; set; }
        public string Ghete1 { get; set; }
        public string Ghete2 { get; set; }
        public string Ghete3 { get; set; }
        public string Ghete42 { get; set; }
        public string Tedad1 { get; set; }
        public string Tedad2 { get; set; }
        public string Tedad3 { get; set; }
        public string Tedad4 { get; set; }
        public string Ghemat1 { get; set; }
        public string Ghemat2 { get; set; }
        public string Ghemat3 { get; set; }
        public string Gheymat4 { get; set; }
        public string Zamanenjam { get; set; }
        public string Namebahrabardar { get; set; }
        public string Emzakarshenasbahrebardar { get; set; }
        public string Noekhadamat { get; set; }
    }
}
