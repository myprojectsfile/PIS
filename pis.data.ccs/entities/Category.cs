using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Category
    {
        public Category()
        {
            Index = new HashSet<Index>();
        }

        public int Id { get; set; }
        public string CategoryNameFa { get; set; }
        public string CategoryNameEn { get; set; }

        public ICollection<Index> Index { get; set; }
    }
}
