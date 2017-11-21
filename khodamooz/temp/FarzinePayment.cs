using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FarzinePayment
    {
        public int Id { get; set; }
        public string Etc { get; set; }
        public string Ec { get; set; }
        public string FieldName { get; set; }
        public string BankKey { get; set; }
        public string PortKey { get; set; }
        public int? UniqueBankIndex { get; set; }
        public double? Amount { get; set; }
        public string SentStruct { get; set; }
        public DateTime? SentDate { get; set; }
        public string FllowId { get; set; }
        public string ReceivedStruct { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ErrorCode { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedCode { get; set; }
        public string DeletedDescription { get; set; }
        public int? DeletedUserId { get; set; }
        public int? DeletedRoleId { get; set; }
    }
}
