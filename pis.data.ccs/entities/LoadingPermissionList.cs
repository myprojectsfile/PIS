using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class LoadingPermissionList
    {
        public long Id { get; set; }
        public long? LoadingPermissionId { get; set; }
        public long? CargoContainerId { get; set; }
        public string ContainerNumber { get; set; }

        public LoadingPermission LoadingPermission { get; set; }
    }
}
