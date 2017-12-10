using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class PersonsLegal
    {
        public long PersonLegalId { get; set; }
        public string LegalName { get; set; }
        public long? PersonLegalTypeId { get; set; }
        public DateTime? DateRegister { get; set; }
        public string CodeRegister { get; set; }
        public string EconomicalCode { get; set; }
        public string NationalityCode { get; set; }

        public Persons PersonLegal { get; set; }
        public Types PersonLegalType { get; set; }
    }
}
