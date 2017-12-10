using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Persons
    {
        public Persons()
        {
            ReceiptPerson = new HashSet<ReceiptPerson>();
        }

        public long PersonId { get; set; }
        public long? PersonTypeId { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }

        public Types PersonType { get; set; }
        public PersonsLegal PersonsLegal { get; set; }
        public PersonsReal PersonsReal { get; set; }
        public ICollection<ReceiptPerson> ReceiptPerson { get; set; }
    }
}
