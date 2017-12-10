using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Shipping
    {
        public Shipping()
        {
            Bl = new HashSet<Bl>();
            Ship = new HashSet<Ship>();
            ShippingAgent = new HashSet<ShippingAgent>();
            ShippingLine = new HashSet<ShippingLine>();
        }

        public short ShippingId { get; set; }
        public string Name { get; set; }
        public string Tell { get; set; }
        public string Fax { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Abbreviation { get; set; }
        public string ShippingCode { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? Status { get; set; }
        public byte? ShippingAgentType { get; set; }
        public string Address { get; set; }
        public int? ContractTran { get; set; }
        public string EconomicCode { get; set; }
        public string PostalCode { get; set; }
        public string NationalCode { get; set; }
        public string PersianName { get; set; }

        public ICollection<Bl> Bl { get; set; }
        public ICollection<Ship> Ship { get; set; }
        public ICollection<ShippingAgent> ShippingAgent { get; set; }
        public ICollection<ShippingLine> ShippingLine { get; set; }
    }
}
