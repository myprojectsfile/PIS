using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class LoadingPermission
    {
        public LoadingPermission()
        {
            LoadingPermissionList = new HashSet<LoadingPermissionList>();
        }

        public long Id { get; set; }
        public string PermissionNumber { get; set; }
        public long? CustomId { get; set; }
        public long? ReceiptId { get; set; }
        public string RegisterOperator { get; set; }
        public DateTime? RegisterDate { get; set; }
        public double? Amount { get; set; }
        public DateTime? CreditDate { get; set; }

        public ICollection<LoadingPermissionList> LoadingPermissionList { get; set; }
    }
}
