﻿using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Rptcategory
    {
        public int CategoryId { get; set; }
        public int? DbCode { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int? ParentId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CategoryType { get; set; }
    }
}
