using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FcfQueue
    {
        public int QueueCode { get; set; }
        public int SendPriority { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string En { get; set; }
        public string Een { get; set; }
        public string Ien { get; set; }
        public string EntityTitle { get; set; }
        public int SenderRoleId { get; set; }
        public string Receivers { get; set; }
        public DateTime QueueEntranceDate { get; set; }
        public string PackagePath { get; set; }
        public bool DoNotProcessFlag { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int ErrorCount { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorTechnicalMessage { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string DestOrganError { get; set; }
        public bool? Sent { get; set; }
        public string RelatedDocsAndFiles { get; set; }
        public bool? IsFst { get; set; }
    }
}
