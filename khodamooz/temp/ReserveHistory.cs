using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class ReserveHistory
    {
        public int Code { get; set; }
        public int ServiceType { get; set; }
        public int ServiceId { get; set; }
        public int MasterUserId { get; set; }
        public int MasterRoleId { get; set; }
        public int ReserveRoleId { get; set; }
        public int ReserveUserId { get; set; }
        public int ReserveId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
