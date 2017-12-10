using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class StoredProcedureLog
    {
        public long Id { get; set; }
        public string StoredProcedureName { get; set; }
        public string Parameter { get; set; }
        public string Result { get; set; }
        public DateTime? CallDate { get; set; }
    }
}
