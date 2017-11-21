using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EmailMngSmtp
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public bool Sslrequisition { get; set; }
        public bool Spalogon { get; set; }
        public bool? Active { get; set; }
        public string Desc { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorUserId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime? LastEditionDate { get; set; }
        public int? LastEditorUserId { get; set; }
        public int? LastEditorRoleId { get; set; }
    }
}
