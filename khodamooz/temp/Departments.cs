using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Departments
    {
        public Departments()
        {
            EmailMngNoteBook = new HashSet<EmailMngNoteBook>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Phones { get; set; }
        public string Faxes { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string LogoPath { get; set; }
        public bool IsReference { get; set; }
        public string DepartmentChartXml { get; set; }
        public string ManagerHonestRoleId { get; set; }
        public string HonestXml { get; set; }
        public string IsNeedToConfirm { get; set; }
        public string StartDateSecretSharing { get; set; }
        public string EndDateSecretSharing { get; set; }
        public int StartWorkTime { get; set; }
        public int EndWorkTime { get; set; }
        public string LawPermissionsXml { get; set; }
        public string CalendarHolidayXml { get; set; }
        public bool? WaterFallLaw { get; set; }
        public string IsNeedConfirmChangePassword { get; set; }
        public bool WorkFlow { get; set; }
        public bool? FormsCategory { get; set; }
        public string EmailConfiguration { get; set; }
        public string FaxConfiguration { get; set; }
        public string Code { get; set; }
        public string ServerAddress { get; set; }
        public int? Oid { get; set; }
        public string FcfadvertisingPolicy { get; set; }
        public bool? InternalWaterFallLaw { get; set; }

        public ICollection<EmailMngNoteBook> EmailMngNoteBook { get; set; }
    }
}
