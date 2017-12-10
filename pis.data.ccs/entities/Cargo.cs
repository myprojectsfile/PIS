using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class Cargo
    {
        public Cargo()
        {
            CargoContainerContent = new HashSet<CargoContainerContent>();
            ExportReceipt = new HashSet<ExportReceipt>();
        }

        public long CustumCargoId { get; set; }
        public string PackegeType { get; set; }
        public string CargoTypeId { get; set; }
        public long DischareTypeId { get; set; }
        public decimal? AssertWeight { get; set; }
        public decimal? ScaleWeight { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string NumberOfWagon { get; set; }
        public int? Package { get; set; }
        public string GoodDescription { get; set; }
        public string NumberOfTruck { get; set; }
        public string StuffingArea { get; set; }
        public string Destination { get; set; }
        public long? VoyageId { get; set; }
        public bool? ReckoningDate { get; set; }

        public CustomExport CustumCargo { get; set; }
        public ICollection<CargoContainerContent> CargoContainerContent { get; set; }
        public ICollection<ExportReceipt> ExportReceipt { get; set; }
    }
}
