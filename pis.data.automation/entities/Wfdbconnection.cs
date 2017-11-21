using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Wfdbconnection
    {
        public int ConnectionId { get; set; }
        public string ConnectionName { get; set; }
        public string Dbtype { get; set; }
        public string DataSource { get; set; }
        public string Dbname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
