using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FcfEventLogResponseToSends
    {
        public int EventCode { get; set; }
        public int ReceiverCode { get; set; }
        public string ConsiderDesc { get; set; }
        public int ParentSendCode { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public int SenderRoleId { get; set; }
        public int ReceiverRoleId { get; set; }
        public string Ipaddress { get; set; }
        public string ResponseDescription { get; set; }
        public DateTime ResponseDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int ErrorFlag { get; set; }
        public string ViewErrorMessage { get; set; }
        public string TechnicalErrorMessage { get; set; }
    }
}
