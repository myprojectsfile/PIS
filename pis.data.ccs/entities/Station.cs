using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Station
    {
        public short Id { get; set; }
        public short DockId { get; set; }
        public short StationNumber { get; set; }
        public int? Length { get; set; }
        public short? TopPosition { get; set; }
        public short? LeftPosition { get; set; }
        public string Direction { get; set; }

        public Dock Dock { get; set; }
    }
}
