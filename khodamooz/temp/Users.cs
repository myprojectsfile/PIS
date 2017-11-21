using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Users
    {
        public Users()
        {
            UsersToken = new HashSet<UsersToken>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public bool? IsActive { get; set; }
        public bool IsOnline { get; set; }
        public bool? IsConfirm { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool? Gender { get; set; }
        public bool? MarriedStatus { get; set; }
        public DateTime? BirthDate { get; set; }
        public short? CountryNo { get; set; }
        public byte? LanguageNo { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhotoPath { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EditionDate { get; set; }
        public string AcceptXml { get; set; }
        public DateTime? LastRefreshTime { get; set; }
        public DateTime? LastChangePassDate { get; set; }
        public string NativeId { get; set; }
        public string PersonnelId { get; set; }
        public string Crc { get; set; }
        public string ActiveSessionId { get; set; }
        public string SystemProfile { get; set; }
        public string Iplocation { get; set; }
        public int DepartmentId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int? UserType { get; set; }
        public string Title { get; set; }

        public ICollection<UsersToken> UsersToken { get; set; }
    }
}
