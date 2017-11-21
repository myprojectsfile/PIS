using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EmailMngImportedReceiveList
    {
        public int Id { get; set; }
        public int ReceiveId { get; set; }
        public int IndicatorId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string ImportEntityNumber { get; set; }

        public EmailMngReceives Receive { get; set; }
    }
}
