using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class SystemCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDiscription { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
