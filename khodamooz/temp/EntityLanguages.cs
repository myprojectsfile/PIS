using System;
using System.Collections.Generic;

namespace pis.Models
{
    public partial class EntityLanguages
    {
        public int LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public string LanguageFarsiName { get; set; }
        public string Direction { get; set; }
    }
}
