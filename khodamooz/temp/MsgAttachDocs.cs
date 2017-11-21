using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class MsgAttachDocs
    {
        public int AttachCode { get; set; }
        public int MsgId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public DateTime CreationDate { get; set; }

        public MsgSents Msg { get; set; }
    }
}
