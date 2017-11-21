using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class UploadFiles
    {
        public int FileCode { get; set; }
        public string SessionKey { get; set; }
        public string FilePath { get; set; }
        public string OriginalFileName { get; set; }
        public string AttachPageRandomNo { get; set; }
        public string Description { get; set; }
    }
}
