﻿using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityPriorityList
    {
        public int Id { get; set; }
        public int? EntityTypeCode { get; set; }
        public int? EntityCode { get; set; }
        public int? PriorityCode { get; set; }
    }
}
