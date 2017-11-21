using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class MsgSents
    {
        public MsgSents()
        {
            MsgAttachDocs = new HashSet<MsgAttachDocs>();
            MsgAttachFiles = new HashSet<MsgAttachFiles>();
            MsgReceivers = new HashSet<MsgReceivers>();
        }

        public int MsgId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime MsgDate { get; set; }
        public int SenderUserId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? RemoveDate { get; set; }
        public int? SenderRoleId { get; set; }

        public ICollection<MsgAttachDocs> MsgAttachDocs { get; set; }
        public ICollection<MsgAttachFiles> MsgAttachFiles { get; set; }
        public ICollection<MsgReceivers> MsgReceivers { get; set; }
    }
}
