﻿using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CargoType
    {
        public long CargoTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HazardousCode { get; set; }

        public HazardousCode HazardousCodeNavigation { get; set; }
    }
}
