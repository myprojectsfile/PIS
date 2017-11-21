using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngFarzinReceivesInfo
    {
        public int Id { get; set; }
        public int ReceiveId { get; set; }
        public int SenderDepartmentId { get; set; }
        public string SenderDepartmentName { get; set; }
        public int SenderIndicatorId { get; set; }
        public int SenderRequesterUserId { get; set; }
        public int SenderRequesterRoleId { get; set; }
        public string SenderSendId { get; set; }
        public bool? SecureReceive { get; set; }
        public string Crc { get; set; }
        public string IndicatorDocNumber { get; set; }
        public DateTime? IndicatorDocDate { get; set; }

        public EmailMngReceives Receive { get; set; }
    }
}
