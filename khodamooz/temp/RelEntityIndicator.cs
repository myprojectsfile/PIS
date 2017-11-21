using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class RelEntityIndicator
    {
        public int Id { get; set; }
        public int Etc { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeFarsiName { get; set; }
        public int Fec { get; set; }
        public bool? IsPrivateSearch { get; set; }
        public int PrivateSearchUserCode { get; set; }
        public int PrivateSearchRoleId { get; set; }
        public string EntityNumber { get; set; }
        public int SecurityLevelCode { get; set; }
        public int? ImportRegisterId { get; set; }
        public int? ImportRegisterRoleId { get; set; }
        public int? ImportIndicatorId { get; set; }
        public string FromType { get; set; }
        public int? FromId { get; set; }
        public string FromCode { get; set; }
        public string From { get; set; }
        public string MainInnerReceiverType { get; set; }
        public int? MainInnerReceiverId { get; set; }
        public string MainInnerReceiverCode { get; set; }
        public string MainInnerReceiver { get; set; }
        public string ImportEntityNumber { get; set; }
        public DateTime? ImportDate { get; set; }
        public string ImportMethod { get; set; }
        public string ImportDesc { get; set; }
        public int? ImportPriority { get; set; }
        public string ImportOriginNo { get; set; }
        public DateTime? ImportOriginDate { get; set; }
        public int? ExportRegisterId { get; set; }
        public int? ExportRegisterRoleId { get; set; }
        public int? ExportIndicatorId { get; set; }
        public string ToType { get; set; }
        public int? ToId { get; set; }
        public string ToCode { get; set; }
        public string To { get; set; }
        public string MainInnerSenderType { get; set; }
        public int? MainInnerSenderId { get; set; }
        public string MainInnerSenderCode { get; set; }
        public string MainInnerSender { get; set; }
        public string ExportEntityNumber { get; set; }
        public DateTime? ExportDate { get; set; }
        public string ExportMethod { get; set; }
        public string ExportDesc { get; set; }
        public int? ExportPriority { get; set; }
        public string NopgAttached { get; set; }
        public string DocType { get; set; }
        public string DocSubjectCode { get; set; }
        public string DocSubject { get; set; }
        public string DocKeywords { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsSent { get; set; }
        public string FollowPassword { get; set; }
        public string SenderCellNumber { get; set; }
    }
}
