using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngLogFormat
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Format { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? EditionDate { get; set; }
        public int? EditorUserId { get; set; }
        public int? EditorRoleId { get; set; }
    }
}
