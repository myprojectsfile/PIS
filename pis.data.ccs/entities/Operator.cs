using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Operator
    {
        public Operator()
        {
            Area = new HashSet<Area>();
            ArrivalOperator = new HashSet<ArrivalOperator>();
            OperatorAgent = new HashSet<OperatorAgent>();
            OperatorService = new HashSet<OperatorService>();
        }

        public short OperatorId { get; set; }
        public string Name { get; set; }
        public string Tell { get; set; }
        public string Fax { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public short Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Share { get; set; }
        public string Address { get; set; }
        public string EconomicCode { get; set; }
        public string RegistrationCode { get; set; }
        public string PostalCode { get; set; }
        public string ThcbankAccountName { get; set; }
        public byte[] AddressLogo { get; set; }
        public string NationalCode { get; set; }
        public string ThcheaderName { get; set; }
        public string PersianName { get; set; }

        public ICollection<Area> Area { get; set; }
        public ICollection<ArrivalOperator> ArrivalOperator { get; set; }
        public ICollection<OperatorAgent> OperatorAgent { get; set; }
        public ICollection<OperatorService> OperatorService { get; set; }
    }
}
