using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class FaxMngFileDependency
    {
        public int FileId { get; set; }
        public int? FaxId { get; set; }
        public int? FileType { get; set; }
        public string FilePath { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public int? Retries { get; set; }
        public string Message { get; set; }
        public int? FileSelected { get; set; }
        public int? FileSelectedSuccess { get; set; }
    }
}
