using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Actions
    {
        public int ActionCode { get; set; }
        public string ActionName { get; set; }
        public string FarsiDescription { get; set; }
        public bool IsSign { get; set; }
        public bool IsArchive { get; set; }
        public bool IsExport { get; set; }
        public bool IsIndicator { get; set; }
        public bool IsSession { get; set; }
        public bool IsUsedForEce { get; set; }
        public bool? IsActiveForCardTable { get; set; }
        public bool? IsActiveForSend { get; set; }
        public bool? IsNeedToResponse { get; set; }
        public string ResponseToSend { get; set; }
        public int? ActionOrder { get; set; }
        public bool? IsActiveForSendCopy { get; set; }
        public bool IsUsedForFcf { get; set; }
    }
}
