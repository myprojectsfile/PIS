using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class Rootcertificates
    {
        public int CarootId { get; set; }
        public string ViewName { get; set; }
        public string SerialNumber { get; set; }
        public string FingerPrint { get; set; }
        public string Certificate { get; set; }
        public int CreateRoleId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
