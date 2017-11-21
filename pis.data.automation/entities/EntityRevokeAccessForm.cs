using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityRevokeAccessForm
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
        public string OfficerName { get; set; }
        public string OfficeOrganization { get; set; }
        public string ChangeType { get; set; }
        public bool? NetProfile { get; set; }
        public bool? Automation { get; set; }
        public bool? PortClearance { get; set; }
        public bool? ImasSystem { get; set; }
        public bool? NamadSystem { get; set; }
        public bool? GcomsSystem { get; set; }
        public bool? SuggestionSystem { get; set; }
        public bool? OrganizationalEmail { get; set; }
        public bool? WebsiteUser { get; set; }
        public bool? InteranetMngUser { get; set; }
        public string OtherSoftware { get; set; }
        public string NetworkAdmin { get; set; }
        public string EmployeSoftware { get; set; }
        public bool? PersonalComputer { get; set; }
        public bool? Laptop { get; set; }
        public bool? Printer { get; set; }
        public bool? Scanner { get; set; }
        public string OtherHardware { get; set; }
        public string EmployeHardware { get; set; }
        public bool? StatusReport { get; set; }
        public bool? SoftwareDoc { get; set; }
        public bool? TechnicalDoc { get; set; }
        public bool? Contract { get; set; }
        public bool? Catalog { get; set; }
        public bool? UsersHelp { get; set; }
        public bool? AdminUser { get; set; }
        public string OtherDoc { get; set; }
        public string EmployeIsms { get; set; }
        public string Discription { get; set; }
        public string BossInformatics { get; set; }
        public DateTime? LetterDoc { get; set; }
    }
}
