using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Country
    {
        public Country()
        {
            Voyage = new HashSet<Voyage>();
        }

        public string CountryCode { get; set; }
        public string Name { get; set; }

        public ICollection<Voyage> Voyage { get; set; }
    }
}
