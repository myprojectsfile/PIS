using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FcfSendReceivers
    {
        public int Code { get; set; }
        public int DestOrganCode { get; set; }
        public int SrcReceiveCode { get; set; }
        public int DestReceiveCode { get; set; }
    }
}
