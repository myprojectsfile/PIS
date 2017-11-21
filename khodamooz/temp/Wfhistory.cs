using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Wfhistory
    {
        public int Id { get; set; }
        public int? FromScenario { get; set; }
        public int? ToScenario { get; set; }
        public int? UserId { get; set; }
        public int? WfexecutedId { get; set; }
        public string Response { get; set; }
        public string Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        public int? GroupNo { get; set; }
    }
}
