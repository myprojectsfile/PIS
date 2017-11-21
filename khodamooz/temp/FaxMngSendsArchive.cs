using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FaxMngSendsArchive
    {
        public int Id { get; set; }
        public string JobId { get; set; }
        public int DepartmentId { get; set; }
        public int IndicatorId { get; set; }
        public int RequesterUserId { get; set; }
        public int RequesterRoleId { get; set; }
        public DateTime RequestDate { get; set; }
        public int Etc { get; set; }
        public int Ec { get; set; }
        public string FaxNumber { get; set; }
        public string RecipientName { get; set; }
        public int LastEditorUserId { get; set; }
        public int LastEditorRoleId { get; set; }
        public DateTime? LastEditionDate { get; set; }
    }
}
