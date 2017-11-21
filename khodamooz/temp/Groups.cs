using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Groups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? AllLocationAccess { get; set; }
        public bool? AllTimesAccess { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Priority { get; set; }
        public bool? UsedForSend { get; set; }
    }
}
