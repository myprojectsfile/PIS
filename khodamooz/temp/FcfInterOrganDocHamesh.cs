using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FcfInterOrganDocHamesh
    {
        public int HameshRegCode { get; set; }
        public int DocRegCode { get; set; }
        public string SrcOrganIp { get; set; }
        public int SrcSendCode { get; set; }
        public int SrcReceiveCode { get; set; }
        public bool IsHamesh { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatorFirstName { get; set; }
        public string CreatorLastName { get; set; }
        public string CreatorRoleName { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Type { get; set; }
        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverRoleName { get; set; }
        public DateTime? SendDate { get; set; }
        public string ActionName { get; set; }
        public int? FollowingCount { get; set; }
        public string ActionDone { get; set; }
        public DateTime? ResponseDate { get; set; }
    }
}
