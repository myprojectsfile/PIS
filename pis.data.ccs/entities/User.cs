using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class User
    {
        public User()
        {
            Cartable = new HashSet<Cartable>();
            Event = new HashSet<Event>();
            ManifestCorrectionApprovedByNavigation = new HashSet<ManifestCorrection>();
            ManifestCorrectionSentByNavigation = new HashSet<ManifestCorrection>();
            Message = new HashSet<Message>();
            OperatorAgent = new HashSet<OperatorAgent>();
            ReceiptCnt = new HashSet<ReceiptCnt>();
            ShippingAgent = new HashSet<ShippingAgent>();
            UserGroup = new HashSet<UserGroup>();
            UserPermission = new HashSet<UserPermission>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
        public string SEmail { get; set; }

        public Role Role { get; set; }
        public ICollection<Cartable> Cartable { get; set; }
        public ICollection<Event> Event { get; set; }
        public ICollection<ManifestCorrection> ManifestCorrectionApprovedByNavigation { get; set; }
        public ICollection<ManifestCorrection> ManifestCorrectionSentByNavigation { get; set; }
        public ICollection<Message> Message { get; set; }
        public ICollection<OperatorAgent> OperatorAgent { get; set; }
        public ICollection<ReceiptCnt> ReceiptCnt { get; set; }
        public ICollection<ShippingAgent> ShippingAgent { get; set; }
        public ICollection<UserGroup> UserGroup { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
    }
}
