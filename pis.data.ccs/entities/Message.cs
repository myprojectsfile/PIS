using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Message
    {
        public Message()
        {
            Cartable = new HashSet<Cartable>();
        }

        public long MessageId { get; set; }
        public int? Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SendDate { get; set; }
        public long? ReferenceId { get; set; }
        public int? MessageTypeId { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentFileName { get; set; }

        public MessageType MessageType { get; set; }
        public User SenderNavigation { get; set; }
        public ICollection<Cartable> Cartable { get; set; }
    }
}
