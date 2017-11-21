using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class FarzinTablesRelations
    {
        public int RelationId { get; set; }
        public int TableId { get; set; }
        public string RelatedField { get; set; }
        public string RelatedTable { get; set; }
        public string RelatedTableField { get; set; }
    }
}
