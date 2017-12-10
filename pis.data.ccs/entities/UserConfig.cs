using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class UserConfig
    {
        public int UserId { get; set; }
        public string PasswordLength { get; set; }
        public string LoginDateBetweenHour { get; set; }
        public string LoginDateSelectedDayWeek { get; set; }
        public long? PasswordComplexity { get; set; }
        public bool? PasswordChangeNextLogon { get; set; }
        public bool? PasswordChangeDisabled { get; set; }
        public int? PasswordExpiredTime { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int? AccountDisabledTime { get; set; }
        public int? SessionTimeOut { get; set; }
        public string Description { get; set; }
        public DateTime? PasswordChangeDateTime { get; set; }
    }
}
