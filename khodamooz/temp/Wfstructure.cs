using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Wfstructure
    {
        public int Wfid { get; set; }
        public int? Wftype { get; set; }
        public int? Wfstate { get; set; }
        public string AppName { get; set; }
        public string Wfname { get; set; }
        public string WfstructureXml { get; set; }
        public string WfextendedScenariosXml { get; set; }
        public string MaxScenarioCode { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? UsedLastVersion { get; set; }
    }
}
