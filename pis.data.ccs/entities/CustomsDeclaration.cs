using System;
using System.Collections.Generic;

namespace pis.data.ccs.entities
{
    public partial class CustomsDeclaration
    {
        public long Id { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public string AssessmentNumber { get; set; }
        public string BankAddress { get; set; }
        public string BankBranchCode { get; set; }
        public string BankBranchName { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankTellerNationalId { get; set; }
        public string BorderModeOfTransport { get; set; }
        public string CarrierIdentity { get; set; }
        public int? CommodityItemQuantity { get; set; }
        public string ConsigneeAddress { get; set; }
        public string ConsigneeFullName { get; set; }
        public string ConsigneeNationalId { get; set; }
        public decimal? CurrencyRate { get; set; }
        public string CurrencyTypeCode { get; set; }
        public DateTime? CustomsDeclarationRegistrationDate { get; set; }
        public string CustomsDeclarationSerialNumber { get; set; }
        public string DeclarantAddress { get; set; }
        public string DeclarantFullName { get; set; }
        public string DeclarantNationalId { get; set; }
        public string DeclarationStatus { get; set; }
        public string DeclarationTypeCode { get; set; }
        public string DestinationCountryCode { get; set; }
        public string DischargeCountryCode { get; set; }
        public string EntranceCustomsCode { get; set; }
        public string EntranceCustomsName { get; set; }
        public string ExportCountryCode { get; set; }
        public string FinancialDocumentNumber { get; set; }
        public DateTime? FinancialReceiptDate { get; set; }
        public string FinancialReceiptNumber { get; set; }
        public string InlandModeOfTransport { get; set; }
        public string InternationalShippingAgreementType { get; set; }
        public string KutajNumber { get; set; }
        public string LastOperationOnDeclaration { get; set; }
        public string LocationOfGoods { get; set; }
        public string ManifestRegistrationNumber { get; set; }
        public string NatureOfTransaction { get; set; }
        public string OriginCountryCode { get; set; }
        public string OriginProvinceCode { get; set; }
        public DateTime? PreDeclarationDate { get; set; }
        public decimal? TotalCurrencyValue { get; set; }
        public decimal? TotalDutyValue { get; set; }
        public decimal? TotalIrrvalue { get; set; }
        public decimal? TotalPackagesCount { get; set; }
        public string LCreferenceNumber { get; set; }
    }
}
