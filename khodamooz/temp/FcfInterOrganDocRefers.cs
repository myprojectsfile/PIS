using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FcfInterOrganDocRefers
    {
        public int DocRegCode { get; set; }
        public string OriginOrganIp { get; set; }
        public int Etco { get; set; }
        public int Eco { get; set; }
        public string OriginExportEntityNumber { get; set; }
        public string OriginEntityNumber { get; set; }
        public string SrcOrganIp { get; set; }
        public int Etcs { get; set; }
        public int Ecs { get; set; }
        public string SrcImportEntityNumber { get; set; }
        public string SrcExportEntityNumber { get; set; }
        public string SrcEntityNumber { get; set; }
        public int Etcd { get; set; }
        public int Ecd { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
