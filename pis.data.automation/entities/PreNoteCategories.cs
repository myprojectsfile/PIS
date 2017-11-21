using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class PreNoteCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int? ParentId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? Etc { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
