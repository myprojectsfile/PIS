using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class WfvirtualUser
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string UserIdstring { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
