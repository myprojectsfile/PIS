using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class RolesExTimeAccess
    {
        public int TimeAccessCode { get; set; }
        public int RoleId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }

        public Roles Role { get; set; }
    }
}
