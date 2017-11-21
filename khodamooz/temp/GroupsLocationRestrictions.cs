using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class GroupsLocationRestrictions
    {
        public int LocationId { get; set; }
        public int GroupCode { get; set; }
        public string Ip { get; set; }
        public int Count { get; set; }
    }
}
