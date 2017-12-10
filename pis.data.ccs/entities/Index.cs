using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Index
    {
        public Index()
        {
            IndexParameter = new HashSet<IndexParameter>();
        }

        public int Id { get; set; }
        public string NameFa { get; set; }
        public string NameEn { get; set; }
        public string WebMehod { get; set; }
        public string IndexFile { get; set; }
        public int Category { get; set; }
        public string Host { get; set; }
        public short? Benumber { get; set; }

        public Category CategoryNavigation { get; set; }
        public ICollection<IndexParameter> IndexParameter { get; set; }
    }
}
