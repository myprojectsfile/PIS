using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class DeclaredCommodityInformation
    {
        public long Id { get; set; }
        public string CommodityDescription { get; set; }
        public string CommodityHscode { get; set; }
        public decimal? CommodityItemCurrencyValue { get; set; }
        public string CommodityItemNumber { get; set; }
        public string CommodityTariffDescription { get; set; }
        public decimal? DeliveryIrrvalue { get; set; }
        public decimal? DutyIrramount { get; set; }
        public decimal? GrossWeightInKg { get; set; }
        public string IdentificationOfWarehouse { get; set; }
        public decimal? InsuranceIrrvalue { get; set; }
        public decimal? NetWeightInKg { get; set; }
        public string OrderRegistrationNumber { get; set; }
        public string OriginCountryCode { get; set; }
        public decimal? PackageCount { get; set; }
        public string PackageTypeCode { get; set; }
        public decimal? TaxesRate { get; set; }
        public decimal? CIfirrvalue { get; set; }
        public long CustomsDeclarationId { get; set; }
    }
}
