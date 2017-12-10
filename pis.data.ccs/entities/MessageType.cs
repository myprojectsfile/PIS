using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class MessageType
    {
        public MessageType()
        {
            Message = new HashSet<Message>();
        }

        public int MessageTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Message> Message { get; set; }
    }
}
