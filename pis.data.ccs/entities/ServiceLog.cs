using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ServiceLog
    {
        public long ServiceLogId { get; set; }
        public string WebMethod { get; set; }
        public DateTime ResponseTime { get; set; }
        public short Result { get; set; }
        public short ServiceId { get; set; }
        public short? Operator { get; set; }
        public string Description { get; set; }

        public ServiceResult ResultNavigation { get; set; }
        public Service Service { get; set; }
    }
}
