using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class GroupsRights
    {
        public int GroupId { get; set; }
        public int RightId { get; set; }
        public string IsConfirm { get; set; }
        public string AcceptXml { get; set; }
    }
}
