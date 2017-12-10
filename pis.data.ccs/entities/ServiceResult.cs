using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class ServiceResult
    {
        public ServiceResult()
        {
            ServiceLog = new HashSet<ServiceLog>();
        }

        public short ServiceResultId { get; set; }
        public string Result { get; set; }

        public ICollection<ServiceLog> ServiceLog { get; set; }
    }
}
