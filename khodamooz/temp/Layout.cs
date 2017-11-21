using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class Layout
    {
        public int LayoutId { get; set; }
        public int ItemId { get; set; }
        public string LayoutName { get; set; }
        public string LayoutPath { get; set; }
        public bool IsActive { get; set; }
        public int? LayoutType { get; set; }
        public string LayoutPass { get; set; }
        public int? Priority { get; set; }
    }
}
