using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class OperatorService
    {
        public short OperatorId { get; set; }
        public short ServiceId { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string X509Key { get; set; }

        public Operator Operator { get; set; }
        public Service Service { get; set; }
    }
}
