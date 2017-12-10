using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Types
    {
        public Types()
        {
            ArrivalOperator = new HashSet<ArrivalOperator>();
            Persons = new HashSet<Persons>();
            PersonsLegal = new HashSet<PersonsLegal>();
            Receipt = new HashSet<Receipt>();
            SlotSharing = new HashSet<SlotSharing>();
        }

        public long TypeId { get; set; }
        public string TypeKey { get; set; }
        public string TypeFarsi { get; set; }
        public long? DomainId { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDateTime { get; set; }

        public Domain Domain { get; set; }
        public ICollection<ArrivalOperator> ArrivalOperator { get; set; }
        public ICollection<Persons> Persons { get; set; }
        public ICollection<PersonsLegal> PersonsLegal { get; set; }
        public ICollection<Receipt> Receipt { get; set; }
        public ICollection<SlotSharing> SlotSharing { get; set; }
    }
}
