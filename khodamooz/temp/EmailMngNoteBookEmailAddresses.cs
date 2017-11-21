using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngNoteBookEmailAddresses
    {
        public int Id { get; set; }
        public int NoteBookId { get; set; }
        public string EmailAddress { get; set; }

        public EmailMngNoteBook NoteBook { get; set; }
    }
}
