using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Contacts
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomeStreet { get; set; }
        public string HomeCity { get; set; }
        public string HomeProvince { get; set; }
        public string HomeCountry { get; set; }
        public string HomePostalCode { get; set; }
        public string HomePhone { get; set; }
        public string HomeCell { get; set; }
        public string HomeFax { get; set; }
        public string HomeWebSite { get; set; }
        public string WorkCompany { get; set; }
        public string WorkDepartment { get; set; }
        public string WorkRole { get; set; }
        public string WorkStreet { get; set; }
        public string WorkCity { get; set; }
        public string WorkProvince { get; set; }
        public string WorkPostalCode { get; set; }
        public string WorkCountry { get; set; }
        public string WorkPhone { get; set; }
        public string WorkFax { get; set; }
        public string WorkWebSite { get; set; }
        public string Note { get; set; }
        public int? OrganizationId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? CreatorUserId { get; set; }
        public DateTime? CrationDate { get; set; }
        public short? Type { get; set; }
    }
}
