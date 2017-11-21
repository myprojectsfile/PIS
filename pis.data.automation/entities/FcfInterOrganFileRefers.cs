using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FcfInterOrganFileRefers
    {
        public int FileRegCode { get; set; }
        public string OriginOrganIp { get; set; }
        public int OriginFileCode { get; set; }
        public string SrcOrganIp { get; set; }
        public int SrcFileCode { get; set; }
        public int DestFileCode { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
