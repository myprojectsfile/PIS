using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class UrlserviceExpiredKeys
    {
        public int KeyId { get; set; }
        public string HashedKey { get; set; }
        public string EncryptedKey { get; set; }
        public string UserName { get; set; }
        public string ClientAddress { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
