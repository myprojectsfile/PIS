using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class LoadedTally
    {
        public long LoadedTallyId { get; set; }
        public string ContainerNumber { get; set; }
        public byte Size { get; set; }
        public byte Type { get; set; }
        public DateTime LoadedDate { get; set; }
        public byte FullEmpty { get; set; }
        public string DeviceType { get; set; }
        public string DeviceNumber { get; set; }
        public string TallyClerk { get; set; }
        public string Hhclerk { get; set; }
        public string BayPosition { get; set; }
        public long? LoadedListId { get; set; }
        public long? ContainerId { get; set; }
        public string GantryCode { get; set; }
        public bool? IsDamage { get; set; }
        public bool? IsOg { get; set; }
        public bool? UseWire { get; set; }
    }
}
