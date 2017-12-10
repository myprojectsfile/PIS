using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Service
    {
        public Service()
        {
            OperatorService = new HashSet<OperatorService>();
            ServiceLog = new HashSet<ServiceLog>();
        }

        public short ServiceId { get; set; }
        public string Name { get; set; }
        public bool Direction { get; set; }

        public ICollection<OperatorService> OperatorService { get; set; }
        public ICollection<ServiceLog> ServiceLog { get; set; }
    }
}
