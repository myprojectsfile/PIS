using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class PersonsReal
    {
        public long PersonRealId { get; set; }
        public string Fname { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public bool? Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public string NationalNo { get; set; }
        public string IdentitySerialNo { get; set; }
        public string BirthPlace { get; set; }
        public string IdentityNumber { get; set; }

        public Persons PersonReal { get; set; }
    }
}
