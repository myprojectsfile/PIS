﻿using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class PreDefinedHamesh
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public string HotKey { get; set; }
    }
}
