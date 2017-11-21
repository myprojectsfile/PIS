using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class MsgAttachFiles
    {
        public int AttachCode { get; set; }
        public int MsgId { get; set; }
        public string FilePath { get; set; }
        public string OriginalName { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? IsVoice { get; set; }

        public MsgSents Msg { get; set; }
    }
}
