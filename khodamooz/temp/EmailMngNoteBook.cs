using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngNoteBook
    {
        public EmailMngNoteBook()
        {
            EmailMngNoteBookEmailAddresses = new HashSet<EmailMngNoteBookEmailAddresses>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string OwnerType { get; set; }
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nikename { get; set; }
        public DateTime CreationDate { get; set; }
        public string Desc { get; set; }

        public Departments Department { get; set; }
        public ICollection<EmailMngNoteBookEmailAddresses> EmailMngNoteBookEmailAddresses { get; set; }
    }
}
