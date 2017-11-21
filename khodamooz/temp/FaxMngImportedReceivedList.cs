using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FaxMngImportedReceivedList
    {
        public int Id { get; set; }
        public string JobId { get; set; }
        public int DepartmentId { get; set; }
        public int IndicatorId { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string ImportEntityNumber { get; set; }
        public string FaxServerAddress { get; set; }
    }
}
