using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class RevocationCertificatesList
    {
        public int CrlId { get; set; }
        public int CarootId { get; set; }
        public string Crl { get; set; }
        public int CountOfCertificate { get; set; }
        public string Issuer { get; set; }
        public int CreateRoleId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
