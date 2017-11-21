using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class UsersOtp
    {
        public int OtpId { get; set; }
        public int UserId { get; set; }
        public string Challenge { get; set; }
        public string Response { get; set; }
        public bool Used { get; set; }
    }
}
