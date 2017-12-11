using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace pis.data.ccs.entities
{
    public partial class CCSContext : DbContext
    {
        private IConfigurationRoot _config;

        public CCSContext(DbContextOptions<CCSContext> options, IConfigurationRoot config) :base(options)
        {
            _config = config;
        }


        public virtual DbSet<AddedBl> AddedBl { get; set; }
        public virtual DbSet<AddedContainer> AddedContainer { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaType> AreaType { get; set; }
        public virtual DbSet<ArrivalDetails> ArrivalDetails { get; set; }
        public virtual DbSet<ArrivalNotice> ArrivalNotice { get; set; }
        public virtual DbSet<ArrivalOperator> ArrivalOperator { get; set; }
        public virtual DbSet<ArrivalVesselMovement> ArrivalVesselMovement { get; set; }
        public virtual DbSet<AutoGenerateNumbers> AutoGenerateNumbers { get; set; }
        public virtual DbSet<Bayplane> Bayplane { get; set; }
        public virtual DbSet<BillSharing> BillSharing { get; set; }
        public virtual DbSet<Bl> Bl { get; set; }
        public virtual DbSet<Blcontainer> Blcontainer { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CargoContainer> CargoContainer { get; set; }
        public virtual DbSet<CargoContainerContent> CargoContainerContent { get; set; }
        public virtual DbSet<CargoExitPermission> CargoExitPermission { get; set; }
        public virtual DbSet<CargoType> CargoType { get; set; }
        public virtual DbSet<Cartable> Cartable { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Ccsconfig> Ccsconfig { get; set; }
        public virtual DbSet<Cfsdeparture> Cfsdeparture { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Container> Container { get; set; }
        public virtual DbSet<ContainerDetail> ContainerDetail { get; set; }
        public virtual DbSet<ContainerHistory> ContainerHistory { get; set; }
        public virtual DbSet<ContainerType> ContainerType { get; set; }
        public virtual DbSet<ContentTally> ContentTally { get; set; }
        public virtual DbSet<CorrectionLinkStatus> CorrectionLinkStatus { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CustomerPhones> CustomerPhones { get; set; }
        public virtual DbSet<CustomExport> CustomExport { get; set; }
        public virtual DbSet<CustomsDeclaration> CustomsDeclaration { get; set; }
        public virtual DbSet<CustomsDutyInformation> CustomsDutyInformation { get; set; }
        public virtual DbSet<DealingReceipt> DealingReceipt { get; set; }
        public virtual DbSet<DealingReceiptContainer> DealingReceiptContainer { get; set; }
        public virtual DbSet<DeclaredCommodityInformation> DeclaredCommodityInformation { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<DetaileHokm> DetaileHokm { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<DischargeList> DischargeList { get; set; }
        public virtual DbSet<DischargeTally> DischargeTally { get; set; }
        public virtual DbSet<DischargeType> DischargeType { get; set; }
        public virtual DbSet<Dock> Dock { get; set; }
        public virtual DbSet<Domain> Domain { get; set; }
        public virtual DbSet<EmptyArea> EmptyArea { get; set; }
        public virtual DbSet<EntryType> EntryType { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<ExitPermission> ExitPermission { get; set; }
        public virtual DbSet<ExitType> ExitType { get; set; }
        public virtual DbSet<ExportBl> ExportBl { get; set; }
        public virtual DbSet<ExportReceipt> ExportReceipt { get; set; }
        public virtual DbSet<ExportReceiptContainer> ExportReceiptContainer { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupPermission> GroupPermission { get; set; }
        public virtual DbSet<HazardousCode> HazardousCode { get; set; }
        public virtual DbSet<IdentifyContainer> IdentifyContainer { get; set; }
        public virtual DbSet<Index> Index { get; set; }
        public virtual DbSet<IndexParameter> IndexParameter { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<InvoiceMaster> InvoiceMaster { get; set; }
        public virtual DbSet<InvoicePriceMm> InvoicePriceMm { get; set; }
        public virtual DbSet<InvoiceReceipt> InvoiceReceipt { get; set; }
        public virtual DbSet<InvoiceReceiptContainer> InvoiceReceiptContainer { get; set; }
        public virtual DbSet<InvoiceStorage> InvoiceStorage { get; set; }
        public virtual DbSet<InvoiceThc> InvoiceThc { get; set; }
        public virtual DbSet<InvoiceThcarrival> InvoiceThcarrival { get; set; }
        public virtual DbSet<InvoiceThcdetail> InvoiceThcdetail { get; set; }
        public virtual DbSet<InvoiceThckey> InvoiceThckey { get; set; }
        public virtual DbSet<IsocontainerCode> IsocontainerCode { get; set; }
        public virtual DbSet<IsocontainerCodebapli> IsocontainerCodebapli { get; set; }
        public virtual DbSet<LoadedList> LoadedList { get; set; }
        public virtual DbSet<LoadedTally> LoadedTally { get; set; }
        public virtual DbSet<LoadingList> LoadingList { get; set; }
        public virtual DbSet<LoadingPermission> LoadingPermission { get; set; }
        public virtual DbSet<LoadingPermissionList> LoadingPermissionList { get; set; }
        public virtual DbSet<LoadingTally> LoadingTally { get; set; }
        public virtual DbSet<LoadingType> LoadingType { get; set; }
        public virtual DbSet<ManifestCorrection> ManifestCorrection { get; set; }
        public virtual DbSet<ManifestCorrectionDetail> ManifestCorrectionDetail { get; set; }
        public virtual DbSet<ManifestCorrectionReason> ManifestCorrectionReason { get; set; }
        public virtual DbSet<ManifestField> ManifestField { get; set; }
        public virtual DbSet<ManifestLinkCorrection> ManifestLinkCorrection { get; set; }
        public virtual DbSet<ManifestReport> ManifestReport { get; set; }
        public virtual DbSet<ManifestTable> ManifestTable { get; set; }
        public virtual DbSet<MasterHokm> MasterHokm { get; set; }
        public virtual DbSet<MeasureUnit> MeasureUnit { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<MetaDataField> MetaDataField { get; set; }
        public virtual DbSet<MetaDataReport> MetaDataReport { get; set; }
        public virtual DbSet<MetaDataReportGroup> MetaDataReportGroup { get; set; }
        public virtual DbSet<MetaDataReportQuery> MetaDataReportQuery { get; set; }
        public virtual DbSet<MetaDataTable> MetaDataTable { get; set; }
        public virtual DbSet<Minute> Minute { get; set; }
        public virtual DbSet<MinuteContent> MinuteContent { get; set; }
        public virtual DbSet<MinuteItem> MinuteItem { get; set; }
        public virtual DbSet<MinuteItemType> MinuteItemType { get; set; }
        public virtual DbSet<MovementType> MovementType { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<OperationCategory> OperationCategory { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<OperatorAgent> OperatorAgent { get; set; }
        public virtual DbSet<OperatorService> OperatorService { get; set; }
        public virtual DbSet<PackageType> PackageType { get; set; }
        public virtual DbSet<PagePermission> PagePermission { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PersonsLegal> PersonsLegal { get; set; }
        public virtual DbSet<PersonsReal> PersonsReal { get; set; }
        public virtual DbSet<Port> Port { get; set; }
        public virtual DbSet<PortAvailability> PortAvailability { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReceiptCnt> ReceiptCnt { get; set; }
        public virtual DbSet<ReceiptContainer> ReceiptContainer { get; set; }
        public virtual DbSet<ReceiptPerson> ReceiptPerson { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportParameter> ReportParameter { get; set; }
        public virtual DbSet<ReportRequiredField> ReportRequiredField { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SealingParty> SealingParty { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceLog> ServiceLog { get; set; }
        public virtual DbSet<ServiceResult> ServiceResult { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<ShippingAgent> ShippingAgent { get; set; }
        public virtual DbSet<ShippingLine> ShippingLine { get; set; }
        public virtual DbSet<ShipShare> ShipShare { get; set; }
        public virtual DbSet<SlotSharing> SlotSharing { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<StoredProcedureLog> StoredProcedureLog { get; set; }
        public virtual DbSet<TaxExemption> TaxExemption { get; set; }
        public virtual DbSet<Thctariff> Thctariff { get; set; }
        public virtual DbSet<ThctariffMove> ThctariffMove { get; set; }
        public virtual DbSet<ThctarrifDetail> ThctarrifDetail { get; set; }
        public virtual DbSet<ThctarrifMain> ThctarrifMain { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<TrackingObjects> TrackingObjects { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<Uipage> Uipage { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserConfig> UserConfig { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserPasswordHistory> UserPasswordHistory { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<VesselMovementPosition> VesselMovementPosition { get; set; }
        public virtual DbSet<Voyage> Voyage { get; set; }
        public virtual DbSet<WebConfigAppSettings> WebConfigAppSettings { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SRV_AmareInpOutShipContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SRV_AmareRosoobTideWater'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SRV_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SRV_CFS2115657'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SanaRate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Product'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CargoExitPermissionContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CargoReturnExitPermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExitPermissionBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExportReckoning'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LoadingExitPermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BLContainerHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LoadingExitPermissionContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BLHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReceiptCustoms'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReceiptHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SealNumber'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VoyageHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ValueTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SRV_Cfstest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.blEntry'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.new_table'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ArrivalNoticeGateWay'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InvoiceWarehousing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InvoiceWarehousingDetail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InvoiceWarehousingMaster'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InvoiceWarehousingTariff'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CFSTerminal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InvoiceWarehousingTariffDetail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TableTest2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReceiptCustomsChange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReceiptHistoryContainer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pvt'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["Data:CCSConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddedBl>(entity =>
            {
                entity.ToTable("AddedBL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Blnumber)
                    .HasColumnName("BLNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Consignee)
                    .HasColumnName("consignee")
                    .HasMaxLength(200);

                entity.Property(e => e.CorrectionId).HasColumnName("correctionID");

                entity.Property(e => e.EntryType).HasColumnName("entryType");

                entity.Property(e => e.GoodsDescription)
                    .HasColumnName("goodsDescription")
                    .HasMaxLength(2000);

                entity.Property(e => e.Hscode)
                    .HasColumnName("HSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Notify)
                    .HasColumnName("notify")
                    .HasMaxLength(200);

                entity.Property(e => e.OldBlnumber)
                    .HasColumnName("oldBLNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.PackagesType)
                    .HasColumnName("packagesType")
                    .HasColumnType("char(3)");

                entity.Property(e => e.Shipper)
                    .HasColumnName("shipper")
                    .HasMaxLength(200);

                entity.Property(e => e.VoyageId).HasColumnName("voyageID");

                entity.HasOne(d => d.Correction)
                    .WithMany(p => p.AddedBl)
                    .HasForeignKey(d => d.CorrectionId)
                    .HasConstraintName("FK_AddedBL_ManifestCorrection");
            });

            modelBuilder.Entity<AddedContainer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContainerNumber)
                    .HasColumnName("containerNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.ContainerSize).HasColumnName("containerSize");

                entity.Property(e => e.ContainerType).HasColumnName("containerType");

                entity.Property(e => e.CorrectionId).HasColumnName("correctionID");

                entity.Property(e => e.DischareDate)
                    .HasColumnName("dischareDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlashPoint).HasColumnName("flashPoint");

                entity.Property(e => e.FlashPointUnit).HasColumnName("flashPointUnit");

                entity.Property(e => e.FullEmpty).HasColumnName("fullEmpty");

                entity.Property(e => e.GrossWeight).HasColumnName("grossWeight");

                entity.Property(e => e.HazardousCode)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HazardousVersion)
                    .HasColumnName("hazardousVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.MovementType).HasColumnName("movementType");

                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(200);

                entity.Property(e => e.PackageType)
                    .HasColumnName("packageType")
                    .HasColumnType("char(3)");

                entity.Property(e => e.PackagesCount).HasColumnName("packagesCount");

                entity.Property(e => e.PackingGroup)
                    .HasColumnName("packingGroup")
                    .HasMaxLength(15);

                entity.Property(e => e.PageNo).HasColumnName("pageNo");

                entity.Property(e => e.PortOfDestination).HasColumnType("char(6)");

                entity.Property(e => e.PortOfDischarge)
                    .HasColumnName("portOfDischarge")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfLoading)
                    .HasColumnName("portOfLoading")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfTranship).HasColumnType("char(6)");

                entity.Property(e => e.Rftemperature).HasColumnName("RFTemperature");

                entity.Property(e => e.RftemperatureUnit).HasColumnName("RFTemperatureUnit");

                entity.Property(e => e.SealNumber)
                    .HasColumnName("sealNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SealingCondition).HasColumnName("sealingCondition");

                entity.Property(e => e.SealingParty)
                    .HasColumnName("sealingParty")
                    .HasColumnType("char(3)");

                entity.Property(e => e.TareWeight).HasColumnName("tareWeight");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.Yard)
                    .HasColumnName("yard")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany(p => p.AddedContainer)
                    .HasForeignKey(d => d.ContainerType)
                    .HasConstraintName("FK_AddedContainer_ContainerType");

                entity.HasOne(d => d.Correction)
                    .WithMany(p => p.AddedContainer)
                    .HasForeignKey(d => d.CorrectionId)
                    .HasConstraintName("FK_AddedContainer_ManifestCorrection");

                entity.HasOne(d => d.HazardousCodeNavigation)
                    .WithMany(p => p.AddedContainer)
                    .HasForeignKey(d => d.HazardousCode)
                    .HasConstraintName("FK_ContainerCorrection_HazardousCode");

                entity.HasOne(d => d.MovementTypeNavigation)
                    .WithMany(p => p.AddedContainer)
                    .HasForeignKey(d => d.MovementType)
                    .HasConstraintName("FK_ContainerCorrection_MovementType");

                entity.HasOne(d => d.SealingPartyNavigation)
                    .WithMany(p => p.AddedContainer)
                    .HasForeignKey(d => d.SealingParty)
                    .HasConstraintName("FK_ContainerCorrection_SealingParty");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaCode).HasColumnType("char(4)");

                entity.Property(e => e.AreaTypeId).HasColumnName("AreaTypeID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.MaxAllowedCapacity).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.PersianName).HasMaxLength(500);

                entity.Property(e => e.Po)
                    .HasColumnName("po")
                    .HasColumnType("nchar(10)");

                entity.HasOne(d => d.AreaType)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.AreaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_AreaType");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.OperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_Operator");
            });

            modelBuilder.Entity<AreaType>(entity =>
            {
                entity.Property(e => e.AreaTypeId)
                    .HasColumnName("AreaTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ArrivalDetails>(entity =>
            {
                entity.HasKey(e => e.ArrivalId);

                entity.Property(e => e.ArrivalId).ValueGeneratedNever();

                entity.Property(e => e.Dg20fdis).HasColumnName("DG20FDis");

                entity.Property(e => e.Dg20fload).HasColumnName("DG20FLoad");

                entity.Property(e => e.Dg20mdis).HasColumnName("DG20MDis");

                entity.Property(e => e.Dg20mload).HasColumnName("DG20MLoad");

                entity.Property(e => e.Dg40fdis).HasColumnName("DG40FDis");

                entity.Property(e => e.Dg40fload).HasColumnName("DG40FLoad");

                entity.Property(e => e.Dg40mdis).HasColumnName("DG40MDis");

                entity.Property(e => e.Dg40mload).HasColumnName("DG40MLoad");

                entity.Property(e => e.Dgimcodedis)
                    .HasColumnName("DGIMCODEDis")
                    .HasMaxLength(50);

                entity.Property(e => e.Dgimcodeload)
                    .HasColumnName("DGIMCODELoad")
                    .HasMaxLength(50);

                entity.Property(e => e.DgotherDis).HasColumnName("DGOtherDis");

                entity.Property(e => e.DgotherLoad).HasColumnName("DGOtherLoad");

                entity.Property(e => e.Exttran20Dis).HasColumnName("EXTTran20Dis");

                entity.Property(e => e.Exttran40Dis).HasColumnName("EXTTran40Dis");

                entity.Property(e => e.Fcl20).HasColumnName("FCL20");

                entity.Property(e => e.Fcl40).HasColumnName("FCL40");

                entity.Property(e => e.Imp20dis).HasColumnName("IMP20Dis");

                entity.Property(e => e.Imp40dis).HasColumnName("IMP40Dis");

                entity.Property(e => e.Inttran20Dis).HasColumnName("INTTran20Dis");

                entity.Property(e => e.Inttran40Dis).HasColumnName("INTTran40Dis");

                entity.Property(e => e.Lcl20).HasColumnName("LCL20");

                entity.Property(e => e.Lcl40).HasColumnName("LCL40");

                entity.Property(e => e.No20fdis).HasColumnName("NO20FDis");

                entity.Property(e => e.No20fload).HasColumnName("NO20FLoad");

                entity.Property(e => e.No20mdis).HasColumnName("NO20MDis");

                entity.Property(e => e.No20mload).HasColumnName("NO20MLoad");

                entity.Property(e => e.No40fdis).HasColumnName("NO40FDis");

                entity.Property(e => e.No40fload).HasColumnName("NO40FLoad");

                entity.Property(e => e.No40mdis).HasColumnName("NO40MDis");

                entity.Property(e => e.No40mload).HasColumnName("NO40MLoad");

                entity.Property(e => e.NootherDis).HasColumnName("NOOtherDis");

                entity.Property(e => e.NootherLoad).HasColumnName("NOOtherLoad");

                entity.Property(e => e.Og20fdis).HasColumnName("OG20FDis");

                entity.Property(e => e.Og20fload).HasColumnName("OG20FLoad");

                entity.Property(e => e.Og20mdis).HasColumnName("OG20MDis");

                entity.Property(e => e.Og20mload).HasColumnName("OG20MLoad");

                entity.Property(e => e.Og40fdis).HasColumnName("OG40FDis");

                entity.Property(e => e.Og40fload).HasColumnName("OG40FLoad");

                entity.Property(e => e.Og40mdis).HasColumnName("OG40MDis");

                entity.Property(e => e.Og40mload).HasColumnName("OG40MLoad");

                entity.Property(e => e.OgotherDis).HasColumnName("OGOtherDis");

                entity.Property(e => e.OgotherLoad).HasColumnName("OGOtherLoad");

                entity.Property(e => e.Remarkdet).HasMaxLength(50);

                entity.Property(e => e.Rf20fdis).HasColumnName("RF20FDis");

                entity.Property(e => e.Rf20fload).HasColumnName("RF20FLoad");

                entity.Property(e => e.Rf20mdis).HasColumnName("RF20MDis");

                entity.Property(e => e.Rf20mload).HasColumnName("RF20MLoad");

                entity.Property(e => e.Rf40fdis).HasColumnName("RF40FDis");

                entity.Property(e => e.Rf40fload).HasColumnName("RF40FLoad");

                entity.Property(e => e.Rf40mdis).HasColumnName("RF40MDis");

                entity.Property(e => e.Rf40mload).HasColumnName("RF40MLoad");

                entity.Property(e => e.RfotherDis).HasColumnName("RFOtherDis");

                entity.Property(e => e.RfotherLoad).HasColumnName("RFOtherLoad");

                entity.HasOne(d => d.Arrival)
                    .WithOne(p => p.ArrivalDetails)
                    .HasForeignKey<ArrivalDetails>(d => d.ArrivalId)
                    .HasConstraintName("FK_ArrivalDetails_ArrivalNotice");
            });

            modelBuilder.Entity<ArrivalNotice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookingNumber).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DestPort).HasColumnType("char(6)");

                entity.Property(e => e.Dgcargo).HasColumnName("DGCargo");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etd)
                    .HasColumnName("ETD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imo)
                    .HasColumnName("IMO")
                    .HasMaxLength(300);

                entity.Property(e => e.LastPort).HasColumnType("char(6)");

                entity.Property(e => e.NextPort).HasColumnType("char(6)");

                entity.Property(e => e.Ogcargo).HasColumnName("OGCargo");

                entity.Property(e => e.OriginPort).HasColumnType("char(6)");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.Rfcargo).HasColumnName("RFCargo");

                entity.Property(e => e.Rotation).HasMaxLength(50);

                entity.Property(e => e.ShippingParentId).HasColumnName("ShippingParentID");

                entity.Property(e => e.TotEstDisTeu).HasColumnName("TotEstDisTEU");

                entity.Property(e => e.TotEstLoadTeu).HasColumnName("TotEstLoadTEU");

                entity.Property(e => e.TotEstShiftTeu).HasColumnName("TotEstShiftTEU");

                entity.Property(e => e.VesselName).HasMaxLength(150);

                entity.Property(e => e.VoyageNumberDep)
                    .HasColumnName("VoyageNumberDEP")
                    .HasMaxLength(150);

                entity.Property(e => e.VoyageNumberImp)
                    .HasColumnName("VoyageNumberIMP")
                    .HasMaxLength(150);

                entity.Property(e => e.VoyageType).HasMaxLength(50);
            });

            modelBuilder.Entity<ArrivalOperator>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arrival)
                    .WithMany(p => p.ArrivalOperator)
                    .HasForeignKey(d => d.ArrivalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArrivalOperator_ArrivalNotice");

                entity.HasOne(d => d.ArrivalType)
                    .WithMany(p => p.ArrivalOperator)
                    .HasForeignKey(d => d.ArrivalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArrivalOperator_Types");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.ArrivalOperator)
                    .HasForeignKey(d => d.OperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArrivalOperator_Operator");
            });

            modelBuilder.Entity<ArrivalVesselMovement>(entity =>
            {
                entity.HasKey(e => e.VesselMovementId);

                entity.Property(e => e.BookingNumber).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.LocationName).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoGenerateNumbers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Year).HasMaxLength(50);
            });

            modelBuilder.Entity<Bayplane>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Carrier).HasMaxLength(50);

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(50);

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.HazardousVersion).HasColumnType("nchar(10)");

                entity.Property(e => e.HazardouseCode).HasColumnType("char(10)");

                entity.Property(e => e.IsocontainerCode)
                    .HasColumnName("ISOContainerCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PageNo).HasMaxLength(50);

                entity.Property(e => e.PortOfDestination)
                    .HasColumnName("portOfDestination")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.PortOfDischargeCode).HasMaxLength(10);

                entity.Property(e => e.PortOfLoadingCode).HasMaxLength(10);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Rftemperature).HasColumnName("RFTemperature");

                entity.Property(e => e.RftemperatureUnit).HasColumnName("RFTemperatureUnit");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");
            });

            modelBuilder.Entity<BillSharing>(entity =>
            {
                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.SharePercent).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Bl>(entity =>
            {
                entity.ToTable("BL");

                entity.HasIndex(e => e.EntryType)
                    .HasName("IX_BLentryType");

                entity.HasIndex(e => new { e.Blid, e.VoyageId })
                    .HasName("_dta_index_BL_7_366676404__K1_K8")
                    .IsUnique();

                entity.HasIndex(e => new { e.Blnumber, e.VoyageId })
                    .HasName("UniqueKey_BLN_V")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShippingId, e.SlotId })
                    .HasName("_dta_index_BL_Slot");

                entity.HasIndex(e => new { e.VoyageId, e.ShippingId })
                    .HasName("_dta_index_BL_VoyageIDShippingID");

                entity.HasIndex(e => new { e.Blnumber, e.ShippingId, e.SlotId, e.Blid })
                    .HasName("_dta_index_BL_7_366676404__K1_2_9_130000");

                entity.HasIndex(e => new { e.Blid, e.Blnumber, e.GoodsDescription, e.Shipper, e.Notify, e.Consignee, e.EntryType, e.ShippingId, e.PartNumber, e.OfficeNumber, e.OfficeDate, e.SlotId, e.DateModifyBl, e.IsFullTally, e.VoyageId })
                    .HasName("ix_test");

                entity.HasIndex(e => new { e.Blid, e.GoodsDescription, e.Shipper, e.Notify, e.Consignee, e.EntryType, e.PartNumber, e.OfficeNumber, e.OfficeDate, e.SlotId, e.DateModifyBl, e.IsFullTally, e.ShippingId, e.Blnumber, e.VoyageId })
                    .HasName("_dta_index-bl-shipping");

                entity.HasIndex(e => new { e.Blnumber, e.GoodsDescription, e.Shipper, e.Notify, e.Consignee, e.VoyageId, e.ShippingId, e.PartNumber, e.OfficeNumber, e.OfficeDate, e.SlotId, e.DateModifyBl, e.IsFullTally, e.EntryType, e.Blid })
                    .HasName("_dta_index_BL_7_366676404__K7_K1_2_3_4_5_6_8_9_10_11_12_13_14_15");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.Blnumber)
                    .HasColumnName("BLNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.Consignee)
                    .HasColumnName("consignee")
                    .HasMaxLength(1500);

                entity.Property(e => e.DateModifyBl)
                    .HasColumnName("DateModifyBL")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryType).HasColumnName("entryType");

                entity.Property(e => e.GoodsDescription)
                    .HasColumnName("goodsDescription")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Hscode)
                    .HasColumnName("HSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Notify)
                    .HasColumnName("notify")
                    .HasMaxLength(1500);

                entity.Property(e => e.OfficeDate).HasColumnType("datetime");

                entity.Property(e => e.OfficeNumber).HasMaxLength(50);

                entity.Property(e => e.PartNumber).HasMaxLength(50);

                entity.Property(e => e.Shipper)
                    .HasColumnName("shipper")
                    .HasMaxLength(1500);

                entity.Property(e => e.VoyageId).HasColumnName("voyageID");

                entity.HasOne(d => d.EntryTypeNavigation)
                    .WithMany(p => p.Bl)
                    .HasForeignKey(d => d.EntryType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BL_EntryType");

                entity.HasOne(d => d.Shipping)
                    .WithMany(p => p.Bl)
                    .HasForeignKey(d => d.ShippingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BL_Shipping");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.Bl)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK_BL_SlotSharing");

                entity.HasOne(d => d.Voyage)
                    .WithMany(p => p.Bl)
                    .HasForeignKey(d => d.VoyageId)
                    .HasConstraintName("FK_BL_Voyage");
            });

            modelBuilder.Entity<Blcontainer>(entity =>
            {
                entity.HasKey(e => e.Blcid);

                entity.ToTable("BLContainer");

                entity.HasIndex(e => e.Blid)
                    .HasName("_dta_index_BLContainer_7_1472060330__K3");

                entity.HasIndex(e => new { e.Blid, e.ContainerId })
                    .HasName("IX_BLContainer");

                entity.HasIndex(e => new { e.Blid, e.PackageType })
                    .HasName("_dta_index_BLContainer_7_1472060330__K3_K5");

                entity.HasIndex(e => new { e.ContainerId, e.Blid })
                    .HasName("_dta_index_BLContainer_7_1472060330__K2_K3");

                entity.HasIndex(e => new { e.Blid, e.Blcid, e.ContainerId, e.PackagesCount, e.PackageType, e.Gross })
                    .HasName("_dta_index_BLContainer_7_1472060330__K3_K1_K2_K4_K5_K6");

                entity.Property(e => e.Blcid).HasColumnName("BLCID");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.ContainerId).HasColumnName("containerID");

                entity.Property(e => e.Gross).HasColumnName("gross");

                entity.Property(e => e.PackageType)
                    .HasColumnName("packageType")
                    .HasMaxLength(10);

                entity.Property(e => e.PackagesCount).HasColumnName("packagesCount");

                entity.HasOne(d => d.Bl)
                    .WithMany(p => p.Blcontainer)
                    .HasForeignKey(d => d.Blid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BLContainer_BL");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.Blcontainer)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("FK_BLContainer_Container");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.BookingId).HasColumnName("bookingID");

                entity.Property(e => e.BookingNumber)
                    .HasColumnName("bookingNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.VesselName)
                    .HasColumnName("vesselName")
                    .HasMaxLength(50);

                entity.Property(e => e.VoyageNumber)
                    .HasColumnName("voyageNumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.CustumCargoId);

                entity.Property(e => e.CustumCargoId)
                    .HasColumnName("CustumCargoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CargoTypeId)
                    .IsRequired()
                    .HasColumnName("CargoTypeID")
                    .HasMaxLength(500);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.DischareTypeId).HasColumnName("DischareTypeID");

                entity.Property(e => e.GoodDescription).HasMaxLength(250);

                entity.Property(e => e.NumberOfTruck).HasMaxLength(50);

                entity.Property(e => e.NumberOfWagon).HasMaxLength(50);

                entity.Property(e => e.Package).HasColumnName("package");

                entity.Property(e => e.PackegeType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.StuffingArea).HasMaxLength(50);

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");

                entity.HasOne(d => d.CustumCargo)
                    .WithOne(p => p.Cargo)
                    .HasForeignKey<Cargo>(d => d.CustumCargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cargo_CustomExport");
            });

            modelBuilder.Entity<CargoContainer>(entity =>
            {
                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CargoId).HasColumnName("cargoId");

                entity.Property(e => e.ContainerId).HasColumnName("containerId");

                entity.Property(e => e.ContainerNumber)
                    .HasColumnName("containerNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.DischargeDate)
                    .HasColumnName("dischargeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitType).HasColumnName("exitType");

                entity.Property(e => e.Felxi)
                    .HasColumnName("felxi")
                    .HasMaxLength(50);

                entity.Property(e => e.FlashPoint).HasColumnName("flashPoint");

                entity.Property(e => e.FlashPointUnit).HasColumnName("flashPointUnit");

                entity.Property(e => e.FullEmpty).HasColumnName("fullEmpty");

                entity.Property(e => e.HazardousCode)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(3);

                entity.Property(e => e.HazardousVersion)
                    .HasColumnName("hazardousVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.IsocontainerCode).HasColumnName("ISOContainerCode");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MoveCfs).HasColumnName("MoveCFS");

                entity.Property(e => e.MovementType).HasColumnName("movementType");

                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(200);

                entity.Property(e => e.Package).HasMaxLength(50);

                entity.Property(e => e.PackageTypeCode)
                    .HasColumnName("packageTypeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PackagesCount).HasColumnName("packagesCount");

                entity.Property(e => e.PackingGroup)
                    .HasColumnName("packingGroup")
                    .HasMaxLength(15);

                entity.Property(e => e.PageNo).HasColumnName("pageNo");

                entity.Property(e => e.PortOfDestination).HasColumnType("char(6)");

                entity.Property(e => e.PortOfDischargeId)
                    .HasColumnName("portOfDischargeID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfLoadingId)
                    .HasColumnName("portOfLoadingID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfTranship).HasColumnType("char(6)");

                entity.Property(e => e.Rftemperature).HasColumnName("RFTemperature");

                entity.Property(e => e.RftemperatureUnit).HasColumnName("RFTemperatureUnit");

                entity.Property(e => e.SealNumber)
                    .HasColumnName("sealNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SealingCondition).HasColumnName("sealingCondition");

                entity.Property(e => e.SealingParty)
                    .HasColumnName("sealingParty")
                    .HasColumnType("char(3)");

                entity.Property(e => e.StaffingLocation).HasColumnName("staffingLocation");

                entity.Property(e => e.StuffingArea)
                    .HasColumnName("stuffingArea")
                    .HasMaxLength(50);

                entity.Property(e => e.StuffingCo)
                    .HasColumnName("stuffingCo")
                    .HasMaxLength(50);

                entity.Property(e => e.StuffingDate).HasColumnType("datetime");

                entity.Property(e => e.TallyClerk).HasMaxLength(50);

                entity.Property(e => e.TareWeight).HasColumnName("tareWeight");

                entity.Property(e => e.TypeOfLoading).HasColumnName("typeOfLoading");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.VoyageId).HasColumnName("voyageID");

                entity.Property(e => e.WagonNo).HasMaxLength(50);

                entity.Property(e => e.Yard)
                    .HasColumnName("yard")
                    .HasMaxLength(50);

                entity.Property(e => e.YardDate)
                    .HasColumnName("yardDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CargoContainerContent>(entity =>
            {
                entity.HasKey(e => new { e.CargoContainerId, e.CustomCargoId });

                entity.Property(e => e.CustomCargoId).HasColumnName("CustomCargoID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.HazardousCode)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(3);

                entity.Property(e => e.HazardousVersion)
                    .HasColumnName("hazardousVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.StuffingArea)
                    .HasColumnName("stuffingArea")
                    .HasMaxLength(50);

                entity.Property(e => e.StuffingCo)
                    .HasColumnName("stuffingCo")
                    .HasMaxLength(50);

                entity.Property(e => e.StuffingDate).HasColumnType("datetime");

                entity.Property(e => e.WagonNo).HasMaxLength(50);

                entity.Property(e => e.Yard).HasMaxLength(50);

                entity.HasOne(d => d.CargoContainer)
                    .WithMany(p => p.CargoContainerContent)
                    .HasForeignKey(d => d.CargoContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargoContainerContent_CargoContainer");

                entity.HasOne(d => d.CustomCargo)
                    .WithMany(p => p.CargoContainerContent)
                    .HasForeignKey(d => d.CustomCargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargoContainerContent_Cargo");
            });

            modelBuilder.Entity<CargoExitPermission>(entity =>
            {
                entity.HasIndex(e => new { e.Blnumber, e.VoyageId, e.ContainerId })
                    .HasName("_dta_index_CargoExitPermission_7_107199482__K3_K4_K2_K8_K11_5");

                entity.HasIndex(e => new { e.Blnumber, e.AreaId, e.VoyageId, e.ContainerId, e.ExitPermissionNumber, e.ContainerNumber, e.ExitDate })
                    .HasName("_dta_index_CargoExitPermission_7_107199482__K3_K2_K16_K8_K11_K4_5");

                entity.Property(e => e.CargoExitPermissionId).HasColumnName("CargoExitPermissionID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Blnumber)
                    .HasColumnName("BLNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(50);

                entity.Property(e => e.CustomPermission)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.ExitDate).HasColumnType("datetime");

                entity.Property(e => e.ExitPermissionNumber).HasMaxLength(50);

                entity.Property(e => e.ExitRealDate).HasColumnType("datetime");

                entity.Property(e => e.IssueBy).HasMaxLength(500);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Receiver).HasMaxLength(500);

                entity.Property(e => e.SerialNumberVerification).HasMaxLength(50);

                entity.Property(e => e.VehicleNumber).HasMaxLength(20);
            });

            modelBuilder.Entity<CargoType>(entity =>
            {
                entity.Property(e => e.CargoTypeId)
                    .HasColumnName("CargoTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.HazardousCode)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.HazardousCodeNavigation)
                    .WithMany(p => p.CargoType)
                    .HasForeignKey(d => d.HazardousCode)
                    .HasConstraintName("FK_CargoType_CargoTypeHazardCode");
            });

            modelBuilder.Entity<Cartable>(entity =>
            {
                entity.HasIndex(e => e.IsRead)
                    .HasName("_dta_index_Cartable_7_249767947__K4");

                entity.Property(e => e.CartableId).HasColumnName("CartableID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.Cartable)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_Cartable_Message");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cartable)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Cartable_User");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryNameEn)
                    .HasColumnName("CategoryNameEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryNameFa)
                    .HasColumnName("CategoryNameFA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ccsconfig>(entity =>
            {
                entity.HasKey(e => e.ConfigId);

                entity.ToTable("CCSConfig");

                entity.Property(e => e.ConfigId).HasColumnName("ConfigID");

                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.FaName).HasMaxLength(50);

                entity.Property(e => e.ProName).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(500);
            });

            modelBuilder.Entity<Cfsdeparture>(entity =>
            {
                entity.ToTable("CFSDeparture");

                entity.Property(e => e.CfsdepartureId).HasColumnName("CFSDepartureID");

                entity.Property(e => e.AreaId).HasColumnName("areaID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("returnDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName).HasMaxLength(150);

                entity.Property(e => e.CodeCity).HasMaxLength(50);
            });

            modelBuilder.Entity<Container>(entity =>
            {
                entity.HasIndex(e => e.IsocontainerCode)
                    .HasName("IX_ContainerIsoCode");

                entity.HasIndex(e => e.MovementType)
                    .HasName("IX_ContainerMovement");

                entity.HasIndex(e => e.OperatorId)
                    .HasName("IX_ContainerOperator");

                entity.HasIndex(e => new { e.ContainerNumber, e.ContainerId })
                    .HasName("index_Container_ContainerID");

                entity.HasIndex(e => new { e.IsocontainerCode, e.FullEmpty, e.ContainerId, e.ContainerNumber })
                    .HasName("_dta_index_Container_7_1337107854__K1_K2_3_4");

                entity.HasIndex(e => new { e.ContainerId, e.ContainerNumber, e.IsocontainerCode, e.FullEmpty, e.PortOfDestination })
                    .HasName("_dta_index_Container_portdestination");

                entity.HasIndex(e => new { e.ContainerId, e.ContainerNumber, e.IsocontainerCode, e.FullEmpty, e.PortOfDischargeId })
                    .HasName("_dta_index_Container_portDischarge");

                entity.HasIndex(e => new { e.ContainerId, e.ContainerNumber, e.IsocontainerCode, e.FullEmpty, e.PortOfLoadingId })
                    .HasName("_dta_index_Container_portLoading");

                entity.HasIndex(e => new { e.ContainerNumber, e.FullEmpty, e.TareWeight, e.SealNumber, e.Owner, e.Agent, e.SealingParty, e.SealingCondition, e.PortOfLoadingId, e.PortOfDischargeId, e.HazardousVersion, e.PageNo, e.FlashPoint, e.FlashPointUnit, e.PackingGroup, e.Unit, e.Locked, e.Destination, e.StaffingLocation, e.DischargeDate, e.TypeOfLoading, e.ExitType, e.Yard, e.YardDate, e.OperatorId, e.Rftemperature, e.RftemperatureUnit, e.MoveCfs, e.PortOfDestination, e.PortOfTranship, e.MovementType, e.ContainerId, e.HazardousCode, e.AreaId, e.IsocontainerCode })
                    .HasName("_dta_index_Container_7_1337107854__K10_K1_K15_K22_K3_2_4_6_7_8_9_11_12_13_14_16_17_18_19_20_21_23_24_25_26_27_28_29_30_31_32_");

                entity.Property(e => e.ContainerId)
                    .HasColumnName("containerID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContainerNumber)
                    .HasColumnName("containerNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.DischargeDate)
                    .HasColumnName("dischargeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitType).HasColumnName("exitType");

                entity.Property(e => e.FlashPoint).HasColumnName("flashPoint");

                entity.Property(e => e.FlashPointUnit).HasColumnName("flashPointUnit");

                entity.Property(e => e.FullEmpty).HasColumnName("fullEmpty");

                entity.Property(e => e.GrossWeight).HasColumnName("grossWeight");

                entity.Property(e => e.HazardousCode)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(3);

                entity.Property(e => e.HazardousVersion)
                    .HasColumnName("hazardousVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.IsocontainerCode).HasColumnName("ISOContainerCode");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MoveCfs).HasColumnName("MoveCFS");

                entity.Property(e => e.MovementType).HasColumnName("movementType");

                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(200);

                entity.Property(e => e.PackingGroup)
                    .HasColumnName("packingGroup")
                    .HasMaxLength(15);

                entity.Property(e => e.PageNo).HasColumnName("pageNo");

                entity.Property(e => e.PortOfDestination).HasColumnType("char(6)");

                entity.Property(e => e.PortOfDischargeId)
                    .HasColumnName("portOfDischargeID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfLoadingId)
                    .HasColumnName("portOfLoadingID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfTranship).HasColumnType("char(6)");

                entity.Property(e => e.Rftemperature).HasColumnName("RFTemperature");

                entity.Property(e => e.RftemperatureUnit).HasColumnName("RFTemperatureUnit");

                entity.Property(e => e.SealNumber)
                    .HasColumnName("sealNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SealingCondition).HasColumnName("sealingCondition");

                entity.Property(e => e.SealingParty)
                    .HasColumnName("sealingParty")
                    .HasColumnType("char(3)");

                entity.Property(e => e.StaffingLocation).HasColumnName("staffingLocation");

                entity.Property(e => e.TareWeight).HasColumnName("tareWeight");

                entity.Property(e => e.TypeOfLoading).HasColumnName("typeOfLoading");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.Yard)
                    .HasColumnName("yard")
                    .HasMaxLength(50);

                entity.Property(e => e.YardDate)
                    .HasColumnName("yardDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ContainerNavigation)
                    .WithOne(p => p.InverseContainerNavigation)
                    .HasForeignKey<Container>(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Container_Container");

                entity.HasOne(d => d.IsocontainerCodeNavigation)
                    .WithMany(p => p.Container)
                    .HasForeignKey(d => d.IsocontainerCode)
                    .HasConstraintName("FK_Container_ISOContainerCode");

                entity.HasOne(d => d.MovementTypeNavigation)
                    .WithMany(p => p.Container)
                    .HasForeignKey(d => d.MovementType)
                    .HasConstraintName("FK_Container_MovementType");

                entity.HasOne(d => d.SealingPartyNavigation)
                    .WithMany(p => p.Container)
                    .HasForeignKey(d => d.SealingParty)
                    .HasConstraintName("FK_Container_SealingParty");
            });

            modelBuilder.Entity<ContainerDetail>(entity =>
            {
                entity.HasKey(e => e.ContainerId);

                entity.Property(e => e.ContainerId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ContainerHistory>(entity =>
            {
                entity.HasKey(e => e.ContainerId);

                entity.HasIndex(e => e.ContainerId)
                    .HasName("PIndex")
                    .IsUnique();

                entity.HasIndex(e => e.IsocontainerCode)
                    .HasName("IX_ContainerHistory");

                entity.HasIndex(e => new { e.ContainerId, e.IsocontainerCode })
                    .HasName("IX_ContainerHistory_2")
                    .IsUnique();

                entity.Property(e => e.ContainerId)
                    .HasColumnName("containerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContainerNumber)
                    .HasColumnName("containerNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.DischargeDate)
                    .HasColumnName("dischargeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitType).HasColumnName("exitType");

                entity.Property(e => e.FlashPoint).HasColumnName("flashPoint");

                entity.Property(e => e.FlashPointUnit).HasColumnName("flashPointUnit");

                entity.Property(e => e.FullEmpty).HasColumnName("fullEmpty");

                entity.Property(e => e.GrossWeight).HasColumnName("grossWeight");

                entity.Property(e => e.HazardousCode)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(3);

                entity.Property(e => e.HazardousVersion)
                    .HasColumnName("hazardousVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.IsocontainerCode).HasColumnName("ISOContainerCode");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MoveCfs).HasColumnName("MoveCFS");

                entity.Property(e => e.MovementType).HasColumnName("movementType");

                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(200);

                entity.Property(e => e.PackingGroup)
                    .HasColumnName("packingGroup")
                    .HasMaxLength(15);

                entity.Property(e => e.PageNo).HasColumnName("pageNo");

                entity.Property(e => e.PortOfDestination).HasColumnType("char(6)");

                entity.Property(e => e.PortOfDischargeId)
                    .HasColumnName("portOfDischargeID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfLoadingId)
                    .HasColumnName("portOfLoadingID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfTranship).HasColumnType("char(6)");

                entity.Property(e => e.Rftemperature).HasColumnName("RFTemperature");

                entity.Property(e => e.RftemperatureUnit).HasColumnName("RFTemperatureUnit");

                entity.Property(e => e.SealNumber)
                    .HasColumnName("sealNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SealingCondition).HasColumnName("sealingCondition");

                entity.Property(e => e.SealingParty)
                    .HasColumnName("sealingParty")
                    .HasColumnType("char(3)");

                entity.Property(e => e.StaffingLocation).HasColumnName("staffingLocation");

                entity.Property(e => e.TareWeight).HasColumnName("tareWeight");

                entity.Property(e => e.TypeOfLoading).HasColumnName("typeOfLoading");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.Yard)
                    .HasColumnName("yard")
                    .HasMaxLength(50);

                entity.Property(e => e.YardDate)
                    .HasColumnName("yardDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IsocontainerCodeNavigation)
                    .WithMany(p => p.ContainerHistory)
                    .HasForeignKey(d => d.IsocontainerCode)
                    .HasConstraintName("FK_ContainerHistory_ISOContainerCode");
            });

            modelBuilder.Entity<ContainerType>(entity =>
            {
                entity.HasKey(e => e.ContainerTypeCode);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<ContentTally>(entity =>
            {
                entity.HasKey(e => e.TallyId);

                entity.Property(e => e.TallyId).HasColumnName("TallyID");

                entity.Property(e => e.Blnumber)
                    .HasColumnName("BLNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Clerk).HasMaxLength(50);

                entity.Property(e => e.ContainerNumber).HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");
            });

            modelBuilder.Entity<CorrectionLinkStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasColumnType("char(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerPhones>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Phone1)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomExport>(entity =>
            {
                entity.HasKey(e => e.CustomId);

                entity.Property(e => e.CustomId).HasColumnName("CustomID");

                entity.Property(e => e.BillingNo).HasMaxLength(50);

                entity.Property(e => e.CustomDischareNo).HasMaxLength(50);

                entity.Property(e => e.CustomPermission).HasMaxLength(50);

                entity.Property(e => e.CustomPermissionDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Sezletter)
                    .HasColumnName("SEZletter")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipper).HasColumnName("shipper");

                entity.Property(e => e.SourceCustom).HasMaxLength(50);

                entity.Property(e => e.TrackingNo).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomsDeclaration>(entity =>
            {
                entity.ToTable("customsDeclaration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssessmentDate)
                    .HasColumnName("assessmentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssessmentNumber)
                    .HasColumnName("assessmentNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.BankAddress)
                    .HasColumnName("bankAddress")
                    .HasMaxLength(150);

                entity.Property(e => e.BankBranchCode)
                    .HasColumnName("bankBranchCode")
                    .HasMaxLength(150);

                entity.Property(e => e.BankBranchName)
                    .HasColumnName("bankBranchName")
                    .HasMaxLength(150);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(150);

                entity.Property(e => e.BankName)
                    .HasColumnName("bankName")
                    .HasMaxLength(150);

                entity.Property(e => e.BankTellerNationalId)
                    .HasColumnName("bankTellerNationalID")
                    .HasMaxLength(150);

                entity.Property(e => e.BorderModeOfTransport)
                    .HasColumnName("borderModeOfTransport")
                    .HasMaxLength(150);

                entity.Property(e => e.CarrierIdentity)
                    .HasColumnName("carrierIdentity")
                    .HasMaxLength(150);

                entity.Property(e => e.CommodityItemQuantity).HasColumnName("commodityItemQuantity");

                entity.Property(e => e.ConsigneeAddress)
                    .HasColumnName("consigneeAddress")
                    .HasMaxLength(150);

                entity.Property(e => e.ConsigneeFullName)
                    .HasColumnName("consigneeFullName")
                    .HasMaxLength(150);

                entity.Property(e => e.ConsigneeNationalId)
                    .HasColumnName("consigneeNationalID")
                    .HasMaxLength(150);

                entity.Property(e => e.CurrencyRate).HasColumnName("currencyRate");

                entity.Property(e => e.CurrencyTypeCode)
                    .HasColumnName("currencyTypeCode")
                    .HasMaxLength(150);

                entity.Property(e => e.CustomsDeclarationRegistrationDate)
                    .HasColumnName("customsDeclarationRegistrationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomsDeclarationSerialNumber)
                    .HasColumnName("customsDeclarationSerialNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.DeclarantAddress)
                    .HasColumnName("declarantAddress")
                    .HasMaxLength(150);

                entity.Property(e => e.DeclarantFullName)
                    .HasColumnName("declarantFullName")
                    .HasMaxLength(150);

                entity.Property(e => e.DeclarantNationalId)
                    .HasColumnName("declarantNationalID")
                    .HasMaxLength(150);

                entity.Property(e => e.DeclarationStatus)
                    .HasColumnName("declarationStatus")
                    .HasMaxLength(150);

                entity.Property(e => e.DeclarationTypeCode)
                    .HasColumnName("declarationTypeCode")
                    .HasMaxLength(150);

                entity.Property(e => e.DestinationCountryCode)
                    .HasColumnName("destinationCountryCode")
                    .HasMaxLength(150);

                entity.Property(e => e.DischargeCountryCode)
                    .HasColumnName("dischargeCountryCode")
                    .HasMaxLength(150);

                entity.Property(e => e.EntranceCustomsCode)
                    .HasColumnName("entranceCustomsCode")
                    .HasMaxLength(150);

                entity.Property(e => e.EntranceCustomsName)
                    .HasColumnName("entranceCustomsName")
                    .HasMaxLength(150);

                entity.Property(e => e.ExportCountryCode)
                    .HasColumnName("exportCountryCode")
                    .HasMaxLength(150);

                entity.Property(e => e.FinancialDocumentNumber)
                    .HasColumnName("financialDocumentNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.FinancialReceiptDate)
                    .HasColumnName("financialReceiptDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinancialReceiptNumber)
                    .HasColumnName("financialReceiptNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.InlandModeOfTransport)
                    .HasColumnName("inlandModeOfTransport")
                    .HasMaxLength(150);

                entity.Property(e => e.InternationalShippingAgreementType)
                    .HasColumnName("internationalShippingAgreementType")
                    .HasMaxLength(150);

                entity.Property(e => e.KutajNumber)
                    .HasColumnName("kutajNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.LCreferenceNumber)
                    .HasColumnName("lCReferenceNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.LastOperationOnDeclaration)
                    .HasColumnName("lastOperationOnDeclaration")
                    .HasMaxLength(150);

                entity.Property(e => e.LocationOfGoods)
                    .HasColumnName("locationOfGoods")
                    .HasMaxLength(150);

                entity.Property(e => e.ManifestRegistrationNumber)
                    .HasColumnName("manifestRegistrationNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.NatureOfTransaction)
                    .HasColumnName("natureOfTransaction")
                    .HasMaxLength(150);

                entity.Property(e => e.OriginCountryCode)
                    .HasColumnName("originCountryCode")
                    .HasMaxLength(150);

                entity.Property(e => e.OriginProvinceCode)
                    .HasColumnName("originProvinceCode")
                    .HasMaxLength(150);

                entity.Property(e => e.PreDeclarationDate)
                    .HasColumnName("preDeclarationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalCurrencyValue).HasColumnName("totalCurrencyValue");

                entity.Property(e => e.TotalDutyValue).HasColumnName("totalDutyValue");

                entity.Property(e => e.TotalIrrvalue).HasColumnName("totalIRRValue");

                entity.Property(e => e.TotalPackagesCount).HasColumnName("totalPackagesCount");
            });

            modelBuilder.Entity<CustomsDutyInformation>(entity =>
            {
                entity.ToTable("customsDutyInformation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeclaredCommodityInformationId).HasColumnName("declaredCommodityInformationId");

                entity.Property(e => e.TaxesAmount).HasColumnName("taxesAmount");

                entity.Property(e => e.TaxesBase).HasColumnName("taxesBase");

                entity.Property(e => e.TaxesCode)
                    .HasColumnName("taxesCode")
                    .HasMaxLength(150);

                entity.Property(e => e.TaxesRate).HasColumnName("taxesRate");
            });

            modelBuilder.Entity<DealingReceipt>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.Property(e => e.ReceiptId)
                    .HasColumnName("ReceiptID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Buyer).HasMaxLength(100);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.DealingReceiptId)
                    .HasColumnName("DealingReceiptID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FactorNumber).HasMaxLength(50);

                entity.Property(e => e.OldReceiptId).HasColumnName("OldReceiptID");

                entity.Property(e => e.Seller).HasMaxLength(100);

                entity.Property(e => e.SellerAddress).HasMaxLength(100);

                entity.Property(e => e.SellerCode).HasMaxLength(200);

                entity.HasOne(d => d.Receipt)
                    .WithOne(p => p.DealingReceipt)
                    .HasForeignKey<DealingReceipt>(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DealingReceipt_Receipt");
            });

            modelBuilder.Entity<DealingReceiptContainer>(entity =>
            {
                entity.HasKey(e => new { e.Blcid, e.DealingReceiptId });

                entity.Property(e => e.Blcid).HasColumnName("BLCID");

                entity.Property(e => e.DealingReceiptId).HasColumnName("DealingReceiptID");

                entity.HasOne(d => d.Blc)
                    .WithMany(p => p.DealingReceiptContainer)
                    .HasForeignKey(d => d.Blcid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DealingReceiptContainer_BLContainer");
            });

            modelBuilder.Entity<DeclaredCommodityInformation>(entity =>
            {
                entity.ToTable("declaredCommodityInformation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CIfirrvalue).HasColumnName("cIFIRRValue");

                entity.Property(e => e.CommodityDescription)
                    .HasColumnName("commodityDescription")
                    .HasMaxLength(150);

                entity.Property(e => e.CommodityHscode)
                    .HasColumnName("commodityHSCode")
                    .HasMaxLength(150);

                entity.Property(e => e.CommodityItemCurrencyValue).HasColumnName("commodityItemCurrencyValue");

                entity.Property(e => e.CommodityItemNumber)
                    .HasColumnName("commodityItemNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.CommodityTariffDescription)
                    .HasColumnName("commodityTariffDescription")
                    .HasMaxLength(150);

                entity.Property(e => e.CustomsDeclarationId).HasColumnName("customsDeclarationId");

                entity.Property(e => e.DeliveryIrrvalue).HasColumnName("deliveryIRRValue");

                entity.Property(e => e.DutyIrramount).HasColumnName("dutyIRRAmount");

                entity.Property(e => e.GrossWeightInKg).HasColumnName("grossWeightInKg");

                entity.Property(e => e.IdentificationOfWarehouse)
                    .HasColumnName("identificationOfWarehouse")
                    .HasMaxLength(150);

                entity.Property(e => e.InsuranceIrrvalue).HasColumnName("insuranceIRRValue");

                entity.Property(e => e.NetWeightInKg).HasColumnName("netWeightInKg");

                entity.Property(e => e.OrderRegistrationNumber)
                    .HasColumnName("orderRegistrationNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.OriginCountryCode)
                    .HasColumnName("originCountryCode")
                    .HasMaxLength(150);

                entity.Property(e => e.PackageCount).HasColumnName("packageCount");

                entity.Property(e => e.PackageTypeCode)
                    .HasColumnName("packageTypeCode")
                    .HasMaxLength(150);

                entity.Property(e => e.TaxesRate).HasColumnName("taxesRate");
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("char(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DetaileHokm>(entity =>
            {
                entity.HasIndex(e => new { e.HokmId, e.Blid })
                    .HasName("_dta_index_DetaileHokm_7_1234155492__K2_K3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerNumber).HasColumnType("char(12)");

                entity.Property(e => e.SlotId).HasColumnName("SlotID");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.HasKey(e => e.DeviceId);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DischargeList>(entity =>
            {
                entity.HasIndex(e => e.VoyageId)
                    .HasName("_dta_index_DischargeList_7_1434488189__K3");

                entity.HasIndex(e => new { e.DischargeDate, e.DischargeListId, e.VoyageId })
                    .HasName("_dta_index_DischargeList_7_1434488189__K1_K3_2");

                entity.Property(e => e.DischargeListId).HasColumnName("DischargeListID");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");

                entity.HasOne(d => d.Voyage)
                    .WithMany(p => p.DischargeList)
                    .HasForeignKey(d => d.VoyageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DischargeList_Voyage");
            });

            modelBuilder.Entity<DischargeTally>(entity =>
            {
                entity.HasIndex(e => new { e.ContainerNumber, e.DischargeId })
                    .HasName("_dta_index_DischargeTallycontainer");

                entity.HasIndex(e => new { e.Size, e.FullEmpty, e.DischargeId, e.ContainerId, e.DischargeTallyId })
                    .HasName("_dta_index_DischargeTally_7_1498488417__K2_K10_K1_5_7");

                entity.HasIndex(e => new { e.Size, e.FullEmpty, e.TallyClerk, e.ContainerId, e.ContainerNumber, e.Type, e.DischargeId, e.DischargeTallyId })
                    .HasName("_dta_index_DischargeTally_7_1498488417__K10_K4_K6_K2_K1_5_7_9");

                entity.Property(e => e.DischargeTallyId).HasColumnName("DischargeTallyID");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(20);

                entity.Property(e => e.DischargeId).HasColumnName("DischargeID");

                entity.Property(e => e.GantryCode).HasMaxLength(50);

                entity.Property(e => e.IsOg).HasColumnName("IsOG");

                entity.Property(e => e.TallyClerk).HasMaxLength(50);

                entity.HasOne(d => d.Discharge)
                    .WithMany(p => p.DischargeTally)
                    .HasForeignKey(d => d.DischargeId)
                    .HasConstraintName("FK_DischargeTally_DischargeList");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.DischargeTally)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_DischargeTally_ContainerType");
            });

            modelBuilder.Entity<DischargeType>(entity =>
            {
                entity.Property(e => e.DischargeTypeId)
                    .HasColumnName("DischargeTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dock>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DockName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PortCode)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Domain>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.DomainFarsi).HasMaxLength(500);

                entity.Property(e => e.DomainKey).HasMaxLength(200);
            });

            modelBuilder.Entity<EmptyArea>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.EmptyAreaId).HasColumnName("EmptyAreaID");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.StripAreaId).HasColumnName("StripAreaID");
            });

            modelBuilder.Entity<EntryType>(entity =>
            {
                entity.HasKey(e => e.BlnaturalCode);

                entity.Property(e => e.BlnaturalCode).HasColumnName("BLNaturalCode");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Tctscode).HasColumnName("TCTSCode");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).HasColumnName("eventID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(3500);

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Operation");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_User");
            });

            modelBuilder.Entity<ExitPermission>(entity =>
            {
                entity.HasIndex(e => new { e.VoyageId, e.ContainerId })
                    .HasName("_dta_index_ExitPermission_7_1527012521__K6_K3_K4_K2_K22");

                entity.Property(e => e.ExitPermissionId)
                    .HasColumnName("ExitPermissionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(50);

                entity.Property(e => e.CustomLicenceDate).HasColumnType("datetime");

                entity.Property(e => e.CustomLicenceNo).HasMaxLength(50);

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExitDate).HasColumnType("datetime");

                entity.Property(e => e.ExitPermissionNumber).HasMaxLength(20);

                entity.Property(e => e.ExitPermissionType).HasMaxLength(4);

                entity.Property(e => e.ExitRealDate).HasColumnType("datetime");

                entity.Property(e => e.ExitType).HasMaxLength(50);

                entity.Property(e => e.IssuedBy).HasMaxLength(50);

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadingPermissionNumber).HasMaxLength(50);

                entity.Property(e => e.Receiver).HasMaxLength(500);

                entity.Property(e => e.SerialNumberVerification).HasMaxLength(50);

                entity.Property(e => e.TemproraryLicenceNo)
                    .HasColumnName("TemproraryLicenceNO")
                    .HasMaxLength(50);

                entity.Property(e => e.TerminalName).HasMaxLength(50);

                entity.Property(e => e.VehicleNumber).HasMaxLength(20);

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");

                entity.HasOne(d => d.ExitPermissionNavigation)
                    .WithOne(p => p.InverseExitPermissionNavigation)
                    .HasForeignKey<ExitPermission>(d => d.ExitPermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExitPermission_ExitPermission");
            });

            modelBuilder.Entity<ExitType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_exitType_name");

                entity.Property(e => e.ExitTypeId).HasColumnName("exitTypeID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExportBl>(entity =>
            {
                entity.HasKey(e => e.Eblid);

                entity.ToTable("ExportBL");

                entity.Property(e => e.Eblid).HasColumnName("EBLID");

                entity.Property(e => e.BillingNo).HasMaxLength(50);

                entity.Property(e => e.Consignee).HasMaxLength(200);

                entity.Property(e => e.CustomDischareNo).HasMaxLength(50);

                entity.Property(e => e.CustomPermission).HasMaxLength(50);

                entity.Property(e => e.CustomPermissionDate).HasColumnType("datetime");

                entity.Property(e => e.DecarantName).HasMaxLength(50);

                entity.Property(e => e.DestinationPortName).HasMaxLength(50);

                entity.Property(e => e.Eblnumber)
                    .HasColumnName("EBLNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.IssuanceDate).HasColumnType("datetime");

                entity.Property(e => e.Notify).HasMaxLength(50);

                entity.Property(e => e.Sezletter)
                    .HasColumnName("SEZletter")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipper).HasColumnName("shipper");

                entity.Property(e => e.SourceCustom).HasMaxLength(50);
            });

            modelBuilder.Entity<ExportReceipt>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.HasIndex(e => e.ReceiptNumber)
                    .HasName("IX_ExportReceipt");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.CancelBy).HasMaxLength(50);

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmBy).HasMaxLength(100);

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.CustomId).HasColumnName("CustomID");

                entity.Property(e => e.DischargePermissionNumber).HasMaxLength(50);

                entity.Property(e => e.ExitCustoms).HasMaxLength(50);

                entity.Property(e => e.IssuanceDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedBy).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.SealNumber).HasMaxLength(20);

                entity.Property(e => e.SourceCustoms).HasMaxLength(50);

                entity.HasOne(d => d.Custom)
                    .WithMany(p => p.ExportReceipt)
                    .HasForeignKey(d => d.CustomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExportReceipt_ExportBL");
            });

            modelBuilder.Entity<ExportReceiptContainer>(entity =>
            {
                entity.HasKey(e => new { e.ExportReceiptId, e.ContainerId });

                entity.Property(e => e.ExportReceiptId).HasColumnName("ExportReceiptID");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.ExportReceiptContainer)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("FK_ExportReceiptContainer_Container");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.GroupName)
                    .HasName("UQ_Group_groupName")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("groupName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GroupPermission>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.OperationId });

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupPermission)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_GroupPermission_Group");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.GroupPermission)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_GroupPermission_Operation");
            });

            modelBuilder.Entity<HazardousCode>(entity =>
            {
                entity.HasKey(e => e.HazardousCode1);

                entity.Property(e => e.HazardousCode1)
                    .HasColumnName("hazardousCode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IdentifyContainer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Back).HasMaxLength(50);

                entity.Property(e => e.Bottom).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Front).HasMaxLength(50);

                entity.Property(e => e.Left).HasMaxLength(50);

                entity.Property(e => e.PrintCount).HasColumnName("printCount");

                entity.Property(e => e.Right).HasMaxLength(50);

                entity.Property(e => e.Top).HasMaxLength(50);

                entity.Property(e => e.TrackNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Index>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Benumber).HasColumnName("BENumber");

                entity.Property(e => e.Host).HasMaxLength(5);

                entity.Property(e => e.IndexFile).HasMaxLength(50);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(100);

                entity.Property(e => e.NameFa)
                    .IsRequired()
                    .HasColumnName("NameFA")
                    .HasMaxLength(200);

                entity.Property(e => e.WebMehod).HasMaxLength(50);

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Index)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Index_Category");
            });

            modelBuilder.Entity<IndexParameter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnumerationTextEn)
                    .HasColumnName("EnumerationTextEN")
                    .HasMaxLength(500);

                entity.Property(e => e.EnumerationTextFa)
                    .HasColumnName("EnumerationTextFA")
                    .HasMaxLength(1000);

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.LabelTextEn)
                    .HasColumnName("LabelTextEN")
                    .HasMaxLength(50);

                entity.Property(e => e.LableTextFa)
                    .IsRequired()
                    .HasColumnName("LableTextFA")
                    .HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Index)
                    .WithMany(p => p.IndexParameter)
                    .HasForeignKey(d => d.IndexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndexParameter_Index");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.AdministrationBlNumber).HasMaxLength(50);

                entity.Property(e => e.Blid)
                    .HasColumnName("BLID")
                    .HasMaxLength(50);

                entity.Property(e => e.CallSign).HasMaxLength(1500);

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceBaseTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.IssuedComplementInvoices).HasMaxLength(1500);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.HasOne(d => d.InvoiceMaster)
                    .WithMany(p => p.InvoiceDetail)
                    .HasForeignKey(d => d.InvoiceMasterId)
                    .HasConstraintName("FK_InvoiceDetail_InvoiceMaster");
            });

            modelBuilder.Entity<InvoiceMaster>(entity =>
            {
                entity.Property(e => e.AdministrationBlNumber).HasMaxLength(150);

                entity.Property(e => e.Blid).HasColumnName("BLId");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceBaseTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.IssuedComplementInvoices).HasMaxLength(250);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(100);

                entity.Property(e => e.VoyageId).HasColumnName("voyageId");
            });

            modelBuilder.Entity<InvoicePriceMm>(entity =>
            {
                entity.HasKey(e => e.Ipmmid);

                entity.ToTable("InvoicePriceMM");

                entity.Property(e => e.Ipmmid).HasColumnName("IPMMId");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("Date_From")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTo)
                    .HasColumnName("Date_To")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpmmcontainerSize)
                    .HasColumnName("IPMMContainerSize")
                    .HasMaxLength(50);

                entity.Property(e => e.IpmmfarsiName)
                    .HasColumnName("IPMMFarsiName")
                    .HasMaxLength(100);

                entity.Property(e => e.Ipmmgroup)
                    .HasColumnName("IPMMGroup")
                    .HasMaxLength(50);

                entity.Property(e => e.Ipmmmax)
                    .HasColumnName("IPMMMax")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ipmmmin)
                    .HasColumnName("IPMMMin")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ipmmprice)
                    .HasColumnName("IPMMPrice")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ipmmtype)
                    .HasColumnName("IPMMType")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeofImmtype)
                    .HasColumnName("TypeofIMMType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceReceipt>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.Property(e => e.AutomobilePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AutomobileRestrainPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Blid).HasColumnName("BLId");

                entity.Property(e => e.CfsStoragePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomsValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Demand).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DischargePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ElectornicServicesPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExtraPortTaxDuty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FreightDeliveryCosts).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GrossAmountBill).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InsuranceExemption).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InsuranceRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InvoiceBaseDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDuty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.InvoiceTax).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LocalAssurance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MovePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OperatorShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PortDuty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PortShare).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReeferPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SealPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoragePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StripPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StuffingPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalGrossAmountBill).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WorkHealth).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<InvoiceReceiptContainer>(entity =>
            {
                entity.Property(e => e.Blid).HasColumnName("BLId");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.FreightDeliveryCosts).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HeavilyPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StripContent).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<InvoiceStorage>(entity =>
            {
                entity.Property(e => e.ContainerSize).HasMaxLength(50);

                entity.Property(e => e.ContainerStatus).HasMaxLength(50);

                entity.Property(e => e.DateFrom)
                    .HasColumnName("Date_from")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTo)
                    .HasColumnName("Date_To")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryType).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<InvoiceThc>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("InvoiceTHC");

                entity.HasIndex(e => new { e.VoyageNumberEntry, e.VoyageNumberExit, e.InvoiceDate, e.VesselName, e.VesselType, e.BerthedOn, e.UsdRoe, e.AgentGrossAmount, e.AgentTax, e.AgentDuty, e.AgentGrandTotal, e.PayableAmount, e.AgentTranshipGrassAmount, e.TypeOfService, e.ShippingLineId, e.InvoiceNumber })
                    .HasName("_dta_index_InvoiceTHC_7_693629564__K48_K2_3_4_5_6_12_19_25_33_35_36_37_39_50_53");

                entity.Property(e => e.AgentAddress).HasMaxLength(500);

                entity.Property(e => e.AgentFax).HasMaxLength(50);

                entity.Property(e => e.AgentName).HasMaxLength(150);

                entity.Property(e => e.AgentPhone).HasMaxLength(50);

                entity.Property(e => e.AgentType).HasMaxLength(50);

                entity.Property(e => e.BerthedOn).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.DestinationPort).HasMaxLength(150);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceGroup).HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.LastPort).HasMaxLength(150);

                entity.Property(e => e.NextPort).HasMaxLength(150);

                entity.Property(e => e.OperatorSerialNumber).HasMaxLength(50);

                entity.Property(e => e.PortOfOrigine).HasMaxLength(150);

                entity.Property(e => e.PortOperatorName).HasMaxLength(150);

                entity.Property(e => e.SanaRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShippingName).HasMaxLength(150);

                entity.Property(e => e.ThccalculateBaseDate)
                    .HasColumnName("THCCalculateBaseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TypeOfService).HasMaxLength(50);

                entity.Property(e => e.UnBerthedOn).HasColumnType("datetime");

                entity.Property(e => e.UsdRoe).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VesselName).HasMaxLength(150);

                entity.Property(e => e.VesselType).HasMaxLength(50);

                entity.Property(e => e.VoyageNumberEntry).HasMaxLength(150);

                entity.Property(e => e.VoyageNumberExit).HasMaxLength(150);
            });

            modelBuilder.Entity<InvoiceThcarrival>(entity =>
            {
                entity.ToTable("InvoiceTHCArrival");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<InvoiceThcdetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetailId);

                entity.ToTable("InvoiceTHCDetail");

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_InvoiceTHCDetail");

                entity.Property(e => e.AgentAddress).HasMaxLength(500);

                entity.Property(e => e.AgentFax).HasMaxLength(50);

                entity.Property(e => e.AgentName).HasMaxLength(150);

                entity.Property(e => e.AgentPhone).HasMaxLength(50);

                entity.Property(e => e.AgentType).HasMaxLength(50);

                entity.Property(e => e.BerthedOn).HasColumnType("datetime");

                entity.Property(e => e.ContainerNumber).HasMaxLength(50);

                entity.Property(e => e.ContainerSize).HasMaxLength(50);

                entity.Property(e => e.ContainerStatus).HasMaxLength(50);

                entity.Property(e => e.ContainerType).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.DestinationPort).HasMaxLength(150);

                entity.Property(e => e.EntryType).HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.LastPort).HasMaxLength(150);

                entity.Property(e => e.NextPort).HasMaxLength(150);

                entity.Property(e => e.PortOfOrigine).HasMaxLength(150);

                entity.Property(e => e.PortOperatorName).HasMaxLength(150);

                entity.Property(e => e.ReeferPlugUnPlug).HasMaxLength(50);

                entity.Property(e => e.ShippingName).HasMaxLength(150);

                entity.Property(e => e.SpecialEquipment).HasMaxLength(50);

                entity.Property(e => e.StowType).HasMaxLength(50);

                entity.Property(e => e.TerminalType).HasMaxLength(50);

                entity.Property(e => e.UnBerthedOn).HasColumnType("datetime");

                entity.Property(e => e.UsdRoe).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VesselName).HasMaxLength(150);

                entity.Property(e => e.VesselType).HasMaxLength(50);

                entity.Property(e => e.VoyageNumberEntry).HasMaxLength(150);

                entity.Property(e => e.VoyageNumberExit).HasMaxLength(150);
            });

            modelBuilder.Entity<InvoiceThckey>(entity =>
            {
                entity.HasKey(e => e.InvoiceKeyId);

                entity.ToTable("InvoiceTHCKey");

                entity.HasIndex(e => new { e.InvoiceKeyId, e.InvoiceKeyName, e.InvoiceCount, e.InvoicePrice, e.InvoiceNumber })
                    .HasName("_dta_index_InvoiceTHCKey_7_613629279__K2_1_3_4_5");

                entity.Property(e => e.InvoiceKeyName).HasMaxLength(250);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<IsocontainerCode>(entity =>
            {
                entity.HasKey(e => e.IsocontainerCode1);

                entity.ToTable("ISOContainerCode");

                entity.Property(e => e.IsocontainerCode1)
                    .HasColumnName("ISOContainerCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContainerSize).HasColumnName("containerSize");

                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany(p => p.IsocontainerCode)
                    .HasForeignKey(d => d.ContainerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ISOContainerCode_ContainerType");
            });

            modelBuilder.Entity<IsocontainerCodebapli>(entity =>
            {
                entity.HasKey(e => e.IsocontainerCodeBapli);

                entity.ToTable("ISOContainerCodebapli");

                entity.Property(e => e.IsocontainerCodeBapli)
                    .HasColumnName("ISOContainerCodeBapli")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContainerSize).HasColumnName("containerSize");

                entity.Property(e => e.IsonewCode)
                    .HasColumnName("ISONewCode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<LoadedList>(entity =>
            {
                entity.HasIndex(e => e.VoyageId)
                    .HasName("_dta_index_LoadedListvoyage");

                entity.HasIndex(e => new { e.EndLoadedDate, e.LoadedListId })
                    .HasName("_dta_index_LoadedList_EndLoadedDate");

                entity.Property(e => e.LoadedListId).HasColumnName("LoadedListID");

                entity.Property(e => e.EndLoadedDate).HasColumnType("datetime");

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");
            });

            modelBuilder.Entity<LoadedTally>(entity =>
            {
                entity.HasIndex(e => new { e.LoadedTallyId, e.Size, e.Type, e.LoadedDate, e.FullEmpty, e.DeviceType, e.DeviceNumber, e.TallyClerk, e.Hhclerk, e.BayPosition, e.LoadedListId, e.ContainerNumber })
                    .HasName("_dta_index_LoadedTally_containernumber");

                entity.HasIndex(e => new { e.LoadedTallyId, e.ContainerNumber, e.Size, e.LoadedDate, e.FullEmpty, e.DeviceType, e.DeviceNumber, e.TallyClerk, e.Hhclerk, e.BayPosition, e.ContainerId, e.LoadedListId, e.Type })
                    .HasName("_dta_index_LoadedTally_7_2007014231__K12_K4_1_2_3_5_6_7_8_9_10_11_13");

                entity.Property(e => e.LoadedTallyId).HasColumnName("LoadedTallyID");

                entity.Property(e => e.BayPosition).HasMaxLength(50);

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(20);

                entity.Property(e => e.DeviceNumber).HasMaxLength(50);

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.GantryCode).HasMaxLength(50);

                entity.Property(e => e.Hhclerk)
                    .HasColumnName("HHClerk")
                    .HasMaxLength(50);

                entity.Property(e => e.IsOg).HasColumnName("IsOG");

                entity.Property(e => e.LoadedDate).HasColumnType("datetime");

                entity.Property(e => e.LoadedListId).HasColumnName("LoadedListID");

                entity.Property(e => e.TallyClerk).HasMaxLength(50);
            });

            modelBuilder.Entity<LoadingList>(entity =>
            {
                entity.Property(e => e.LoadingListId).HasColumnName("LoadingListID");

                entity.Property(e => e.VesselName).HasMaxLength(50);

                entity.Property(e => e.VoyageNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<LoadingPermission>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreditDate).HasColumnType("datetime");

                entity.Property(e => e.CustomId).HasColumnName("CustomID");

                entity.Property(e => e.PermissionNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.RegisterOperator).HasMaxLength(50);
            });

            modelBuilder.Entity<LoadingPermissionList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CargoContainerId).HasColumnName("CargoContainerID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(12);

                entity.Property(e => e.LoadingPermissionId).HasColumnName("LoadingPermissionID");

                entity.HasOne(d => d.LoadingPermission)
                    .WithMany(p => p.LoadingPermissionList)
                    .HasForeignKey(d => d.LoadingPermissionId)
                    .HasConstraintName("FK_LoadingPermissionList_LoadingPermission");
            });

            modelBuilder.Entity<LoadingTally>(entity =>
            {
                entity.Property(e => e.LoadingTallyId).HasColumnName("LoadingTallyID");

                entity.Property(e => e.ContainerNumber).HasMaxLength(20);

                entity.Property(e => e.Destination).HasMaxLength(100);

                entity.Property(e => e.FullEmpty).HasMaxLength(50);

                entity.Property(e => e.LoadingDate).HasColumnType("datetime");

                entity.Property(e => e.LoadingListId).HasColumnName("LoadingListID");

                entity.Property(e => e.Owner).HasMaxLength(100);

                entity.Property(e => e.Pod)
                    .HasColumnName("POD")
                    .HasColumnType("char(6)");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Yard).HasMaxLength(50);

                entity.HasOne(d => d.LoadingList)
                    .WithMany(p => p.LoadingTally)
                    .HasForeignKey(d => d.LoadingListId)
                    .HasConstraintName("FK_LoadingTally_LoadingList");
            });

            modelBuilder.Entity<LoadingType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ_loadingType_name")
                    .IsUnique();

                entity.Property(e => e.LoadingTypeId).HasColumnName("loadingTypeID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ManifestCorrection>(entity =>
            {
                entity.HasKey(e => e.CorrectionId);

                entity.HasIndex(e => new { e.CorrectionId, e.SentDate, e.SentBy, e.Approved, e.ApprovedDate, e.BankReceiptNo, e.CorrectionReasonId, e.BankPrice, e.SlotId, e.Status, e.VoyageId, e.ApprovedBy, e.ShippingId })
                    .HasName("_dta_index_ManifestCorrection_7_384056454__K7_K5_K10_1_2_3_4_6_8_9_11_12_13");

                entity.Property(e => e.CorrectionId)
                    .HasColumnName("correctionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.ApprovedBy).HasColumnName("approvedBy");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("approvedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankPrice)
                    .HasColumnName("bankPrice")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BankReceiptNo)
                    .HasColumnName("bankReceiptNo")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.CorrectionReasonId).HasColumnName("correctionReasonID");

                entity.Property(e => e.SentBy).HasColumnName("sentBy");

                entity.Property(e => e.SentDate)
                    .HasColumnName("sentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoyageId).HasColumnName("voyageID");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.ManifestCorrectionApprovedByNavigation)
                    .HasForeignKey(d => d.ApprovedBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ManifestCorrection_User");

                entity.HasOne(d => d.CorrectionReason)
                    .WithMany(p => p.ManifestCorrection)
                    .HasForeignKey(d => d.CorrectionReasonId)
                    .HasConstraintName("FK_ManifestCorrection_ManifestCorrectionReason");

                entity.HasOne(d => d.SentByNavigation)
                    .WithMany(p => p.ManifestCorrectionSentByNavigation)
                    .HasForeignKey(d => d.SentBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestCorrection_User1");

                entity.HasOne(d => d.Voyage)
                    .WithMany(p => p.ManifestCorrection)
                    .HasForeignKey(d => d.VoyageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestCorrection_Voyage");
            });

            modelBuilder.Entity<ManifestCorrectionDetail>(entity =>
            {
                entity.HasIndex(e => new { e.FieldId, e.Value, e.OldValue, e.Sold, e.Id, e.UniqueId, e.CorrectionId })
                    .HasName("_dta_index_ManifestCorrectionDetail_7_957962489__K5_1_2_3_4_6_7");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorrectionId).HasColumnName("correctionID");

                entity.Property(e => e.FieldId).HasColumnName("fieldID");

                entity.Property(e => e.OldValue)
                    .HasColumnName("oldValue")
                    .HasMaxLength(4000);

                entity.Property(e => e.Sold).HasColumnName("sold");

                entity.Property(e => e.UniqueId)
                    .HasColumnName("uniqueID")
                    .HasMaxLength(30);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Correction)
                    .WithMany(p => p.ManifestCorrectionDetail)
                    .HasForeignKey(d => d.CorrectionId)
                    .HasConstraintName("FK_ManifestCorrectionDetail_ManifestCorrection1");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.ManifestCorrectionDetail)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestCorrectionDetail_ManifestField");
            });

            modelBuilder.Entity<ManifestCorrectionReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ManifestField>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.Property(e => e.FieldId)
                    .HasColumnName("fieldID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FieldName)
                    .HasColumnName("fieldName")
                    .HasMaxLength(20);

                entity.Property(e => e.TableId).HasColumnName("tableID");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.ManifestField)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestField_ManifestTable");
            });

            modelBuilder.Entity<ManifestLinkCorrection>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContainerNumber)
                    .HasColumnName("containerNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.CorrectionId).HasColumnName("correctionID");

                entity.Property(e => e.Gross).HasColumnName("gross");

                entity.Property(e => e.SourceBlnumber)
                    .HasColumnName("sourceBLNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TargetBlnumber)
                    .HasColumnName("targetBLNumber")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Correction)
                    .WithMany(p => p.ManifestLinkCorrection)
                    .HasForeignKey(d => d.CorrectionId)
                    .HasConstraintName("FK_ManifestLinkCorrection_ManifestCorrection");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ManifestLinkCorrection)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestLinkCorrection_CorrectionLinkStatus");
            });

            modelBuilder.Entity<ManifestReport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportEnglisName).HasMaxLength(250);

                entity.Property(e => e.ReportNameFarsi).HasMaxLength(250);

                entity.Property(e => e.ReportUrl)
                    .HasColumnName("ReportURl")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ManifestTable>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.Property(e => e.TableId)
                    .HasColumnName("tableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<MasterHokm>(entity =>
            {
                entity.HasIndex(e => new { e.ArriavalId, e.TrackNum, e.PortDes, e.DateConfirm, e.ShippingId, e.Confirm, e.Id })
                    .HasName("_dta_index_MasterHokm_7_1266155606__K7_K1_2_4_6_8_10");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArriavalId).HasColumnName("ArriavalID");

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DateReg).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.PortDes).HasMaxLength(50);

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.TrackNum).HasMaxLength(100);

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");
            });

            modelBuilder.Entity<MeasureUnit>(entity =>
            {
                entity.HasKey(e => e.MeasureunitCode);

                entity.Property(e => e.MeasureunitCode)
                    .HasColumnName("measureunitCode")
                    .HasColumnType("char(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.AttachmentFileName).HasMaxLength(100);

                entity.Property(e => e.Body).HasColumnType("ntext");

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.MessageType)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.MessageTypeId)
                    .HasConstraintName("FK_Message_MessageType");

                entity.HasOne(d => d.SenderNavigation)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.Sender)
                    .HasConstraintName("FK_Message_User");
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.Property(e => e.MessageTypeId)
                    .HasColumnName("MessageTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MetaDataField>(entity =>
            {
                entity.ToTable("MetaData_Field");

                entity.Property(e => e.MetaDataFieldId).HasColumnName("MetaData_FieldId");

                entity.Property(e => e.MetaDataFieldFarsi)
                    .HasColumnName("MetaData_FieldFarsi")
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDataFieldLatin)
                    .HasColumnName("MetaData_FieldLatin")
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDataTableId).HasColumnName("MetaData_TableId");
            });

            modelBuilder.Entity<MetaDataReport>(entity =>
            {
                entity.ToTable("MetaData_REPORT");

                entity.Property(e => e.MetaDataReportId).HasColumnName("MetaData_ReportId");

                entity.Property(e => e.MetaDataReportContent)
                    .HasColumnName("MetaData_ReportContent")
                    .HasColumnType("image");

                entity.Property(e => e.MetaDataReportDesc)
                    .HasColumnName("MetaData_ReportDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDataReportGroupId).HasColumnName("MetaData_ReportGroupId");

                entity.Property(e => e.MetaDataReportQueryId).HasColumnName("MetaData_ReportQueryId");

                entity.Property(e => e.MetaDataReportTitle)
                    .HasColumnName("MetaData_ReportTitle")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MetaDataReportGroup>(entity =>
            {
                entity.HasKey(e => e.ReportGroupId);

                entity.ToTable("MetaData_REPORT_GROUP");

                entity.Property(e => e.ReportGroupDesc).HasMaxLength(200);

                entity.Property(e => e.ReportGroupTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<MetaDataReportQuery>(entity =>
            {
                entity.ToTable("MetaData_ReportQuery");

                entity.Property(e => e.MetaDataReportQueryId).HasColumnName("MetaData_ReportQueryId");

                entity.Property(e => e.MetaDataReportQueryContent)
                    .HasColumnName("MetaData_ReportQueryContent")
                    .HasMaxLength(2000);

                entity.Property(e => e.MetaDataReportQueryDesc)
                    .HasColumnName("MetaData_ReportQueryDesc")
                    .HasMaxLength(200);

                entity.Property(e => e.MetaDataReportQueryTitle)
                    .HasColumnName("MetaData_ReportQueryTitle")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MetaDataTable>(entity =>
            {
                entity.ToTable("MetaData_Table");

                entity.Property(e => e.MetaDataTableId).HasColumnName("MetaData_TableId");

                entity.Property(e => e.MetaDataTableFarsi)
                    .HasColumnName("MetaData_TableFarsi")
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDataTableLatin)
                    .HasColumnName("MetaData_TableLatin")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Minute>(entity =>
            {
                entity.HasIndex(e => new { e.Date, e.NumberOfnegleReal, e.NumberOfNegleDischarged, e.NumberOfNegleManifest, e.MinuteStatus, e.VoyageId, e.MinuteId, e.Blid })
                    .HasName("_dta_index_Minute_7_570485111__K7_K1_K2_3_4_5_6_8");

                entity.Property(e => e.MinuteId).HasColumnName("MinuteID");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MinuteGroup).HasMaxLength(50);

                entity.Property(e => e.NumberOfnegleReal).HasColumnName("NumberOFNegleReal");

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");
            });

            modelBuilder.Entity<MinuteContent>(entity =>
            {
                entity.HasKey(e => e.MinuteId);

                entity.Property(e => e.MinuteId).HasColumnName("MinuteID");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NumberOfnegleReal).HasColumnName("NumberOFNegleReal");
            });

            modelBuilder.Entity<MinuteItem>(entity =>
            {
                entity.HasIndex(e => new { e.MinuteItemId, e.MinuteId, e.ContainerNumber, e.MinuteItemTypeId })
                    .HasName("_dta_index_MinuteItem_7_186483743__K4_K2_K3_1");

                entity.Property(e => e.ContainerNumber).HasMaxLength(20);

                entity.HasOne(d => d.Minute)
                    .WithMany(p => p.MinuteItem)
                    .HasForeignKey(d => d.MinuteId)
                    .HasConstraintName("FK_MinuteItem_Minute");
            });

            modelBuilder.Entity<MinuteItemType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MovementType>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.HasIndex(e => e.Name)
                    .HasName("UQ_movementType_name")
                    .IsUnique();

                entity.Property(e => e.MoveId).HasColumnName("moveID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.HasIndex(e => e.OperationId)
                    .HasName("UQ_Operation_operationID")
                    .IsUnique();

                entity.Property(e => e.OperationId)
                    .HasColumnName("operationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.OperationNameEn)
                    .IsRequired()
                    .HasColumnName("operationNameEN")
                    .HasMaxLength(50);

                entity.Property(e => e.OperationNameFa)
                    .HasColumnName("operationNameFA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OperationCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.HasIndex(e => e.CategoryNameEn)
                    .HasName("UQ_OperationCategory_categoryName")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryNameEn)
                    .IsRequired()
                    .HasColumnName("categoryNameEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryNameFa)
                    .IsRequired()
                    .HasColumnName("categoryNameFA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AddressLogo).HasColumnType("image");

                entity.Property(e => e.EconomicCode).HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Manager)
                    .HasColumnName("manager")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalCode).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.PersianName).HasMaxLength(500);

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.RegistrationCode).HasMaxLength(20);

                entity.Property(e => e.Share).HasColumnName("share");

                entity.Property(e => e.Tell)
                    .HasColumnName("tell")
                    .HasMaxLength(20);

                entity.Property(e => e.ThcbankAccountName)
                    .HasColumnName("THCBankAccountName")
                    .HasMaxLength(1500);

                entity.Property(e => e.ThcheaderName)
                    .HasColumnName("THCHeaderName")
                    .HasMaxLength(1500);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OperatorAgent>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.UserId });

                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.OperatorAgent)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_OperatorAgent_Operator");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OperatorAgent)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OperatorAgent_User");
            });

            modelBuilder.Entity<OperatorService>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.ServiceId });

                entity.Property(e => e.OperatorId).HasColumnName("operatorID");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(500);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20);

                entity.Property(e => e.X509Key)
                    .HasColumnName("x509Key")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.OperatorService)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_OperatorService_Operator");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.OperatorService)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperatorService_Service");
            });

            modelBuilder.Entity<PackageType>(entity =>
            {
                entity.HasKey(e => e.PackagingCode);

                entity.Property(e => e.PackagingCode)
                    .HasColumnName("packagingCode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AsycudaCode).HasColumnName("asycudaCode");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PagePermission>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.PagePermission)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_PagePermission_Operation");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.PagePermission)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_PagePermission_UIPage");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.PersonTypeId).HasColumnName("Person_TypeId");

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.HasOne(d => d.PersonType)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.PersonTypeId)
                    .HasConstraintName("FK_Persons_Types");
            });

            modelBuilder.Entity<PersonsLegal>(entity =>
            {
                entity.HasKey(e => e.PersonLegalId);

                entity.ToTable("Persons_Legal");

                entity.Property(e => e.PersonLegalId)
                    .HasColumnName("PersonLegal_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodeRegister).HasMaxLength(50);

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.EconomicalCode).HasMaxLength(50);

                entity.Property(e => e.LegalName).HasMaxLength(250);

                entity.Property(e => e.NationalityCode).HasMaxLength(50);

                entity.HasOne(d => d.PersonLegal)
                    .WithOne(p => p.PersonsLegal)
                    .HasForeignKey<PersonsLegal>(d => d.PersonLegalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persons_Legal_Persons");

                entity.HasOne(d => d.PersonLegalType)
                    .WithMany(p => p.PersonsLegal)
                    .HasForeignKey(d => d.PersonLegalTypeId)
                    .HasConstraintName("FK_Persons_Legal_Types");
            });

            modelBuilder.Entity<PersonsReal>(entity =>
            {
                entity.HasKey(e => e.PersonRealId);

                entity.ToTable("Persons_Real");

                entity.Property(e => e.PersonRealId)
                    .HasColumnName("PersonReal_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace).HasMaxLength(200);

                entity.Property(e => e.FatherName).HasMaxLength(250);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(250);

                entity.Property(e => e.IdentityNumber).HasMaxLength(20);

                entity.Property(e => e.IdentitySerialNo).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.NationalNo).HasMaxLength(20);

                entity.HasOne(d => d.PersonReal)
                    .WithOne(p => p.PersonsReal)
                    .HasForeignKey<PersonsReal>(d => d.PersonRealId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persons_Real_Persons");
            });

            modelBuilder.Entity<Port>(entity =>
            {
                entity.HasIndex(e => e.PortCode)
                    .HasName("IX_Port")
                    .IsUnique();

                entity.HasIndex(e => new { e.PortName, e.PortCode })
                    .HasName("_dta_index_Port_7_1348915877__K3_2");

                entity.Property(e => e.PortId)
                    .HasColumnName("portID")
                    .HasColumnType("char(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PortCode)
                    .IsRequired()
                    .HasColumnName("portCode")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortName)
                    .HasColumnName("portName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PortAvailability>(entity =>
            {
                entity.HasIndex(e => e.ContainerNumber)
                    .HasName("IX_PortAvailability_CN");

                entity.HasIndex(e => e.IsExited)
                    .HasName("IX_PortAvailability_IsExit");

                entity.HasIndex(e => new { e.ContainerNumber, e.IsExited })
                    .HasName("IX_PortAvailability_CN_IsExited");

                entity.HasIndex(e => new { e.AreaId, e.ContainerNumber, e.IsExited })
                    .HasName("IX_PortAvailability_CN_Area_IsExited");

                entity.Property(e => e.PortAvailabilityId).HasColumnName("PortAvailabilityID");

                entity.Property(e => e.ContainerNumber).HasColumnType("char(12)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.ExportGateDepartureNo).HasMaxLength(20);

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.Yard).HasMaxLength(20);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasIndex(e => e.Blid)
                    .HasName("IX_Receipt_BL");

                entity.HasIndex(e => e.ReceiptNumber)
                    .HasName("IX_ReceiptNo");

                entity.HasIndex(e => new { e.ReceiptId, e.ReceiptNumber })
                    .HasName("IX_ReceiptNo_ID");

                entity.HasIndex(e => new { e.ReceiptId, e.ReceiptNumber, e.Date, e.Serial, e.Deliverer, e.Declarator, e.Donumber, e.Lcnumber, e.IssuedBy, e.Cancel, e.VoyageId, e.DischargeDate, e.ReceiptParentId, e.ReceiptType, e.Status, e.Blid })
                    .HasName("_dta_index_Receipt_7_897438271__K30_K28_K5_1_2_3_4_11_12_13_14_17_18_25_27_29");

                entity.HasIndex(e => new { e.ReceiptId, e.ReceiptNumber, e.Date, e.Serial, e.Deliverer, e.Declarator, e.Donumber, e.Lcnumber, e.IssuedBy, e.VoyageId, e.DischargeDate, e.Status, e.ReceiptParentId, e.ReceiptType, e.ToOrderId, e.Cancel, e.Blid })
                    .HasName("_dta_index_Receipt_7_897438271__K18_K5_1_2_3_4_11_12_13_14_17_25_27_28_29_30_31");

                entity.HasIndex(e => new { e.ReceiptNumber, e.Date, e.Serial, e.Deliverer, e.Declarator, e.Donumber, e.Lcnumber, e.IssuedBy, e.Cancel, e.VoyageId, e.DischargeDate, e.Status, e.ReceiptParentId, e.ReceiptType, e.ToOrderId, e.Blid, e.ReceiptId })
                    .HasName("_dta_index_Receipt_7_897438271__K5_K1_2_3_4_11_12_13_14_17_18_25_27_28_29_30_31");

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Declarator).HasMaxLength(100);

                entity.Property(e => e.Deliverer).HasMaxLength(100);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.Donumber)
                    .HasColumnName("DONumber")
                    .HasMaxLength(50);

                entity.Property(e => e.IssuedBy).HasMaxLength(50);

                entity.Property(e => e.Lcnumber)
                    .HasColumnName("LCNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiptParentId).HasColumnName("ReceiptParentID");

                entity.Property(e => e.Serial).HasMaxLength(100);

                entity.Property(e => e.VoyageId).HasColumnName("VoyageID");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Receipt)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_Receipt_Types");
            });

            modelBuilder.Entity<ReceiptCnt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.OfficeNo).HasMaxLength(150);

                entity.Property(e => e.ReceiptNo).HasMaxLength(150);

                entity.Property(e => e.VoyageId).HasColumnName("voyageId");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.ReceiptCnt)
                    .HasForeignKey(d => d.LineId)
                    .HasConstraintName("FK_ReceiptCNT_ShippingLine");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReceiptCnt)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ReceiptCNT_User");

                entity.HasOne(d => d.Voyage)
                    .WithMany(p => p.ReceiptCnt)
                    .HasForeignKey(d => d.VoyageId)
                    .HasConstraintName("FK_ReceiptCNT_Voyage");
            });

            modelBuilder.Entity<ReceiptContainer>(entity =>
            {
                entity.Property(e => e.ReceiptContainerId).HasColumnName("ReceiptContainerID");

                entity.Property(e => e.Blnumber).HasMaxLength(50);

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<ReceiptPerson>(entity =>
            {
                entity.HasKey(e => e.PersonReceiptId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ReceiptPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptPerson_Persons");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.ReceiptPerson)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptPerson_Receipt");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Benumber).HasColumnName("BENumber");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Host).HasMaxLength(5);

                entity.Property(e => e.Isenabled).HasColumnName("ISEnabled");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(100);

                entity.Property(e => e.NameFa)
                    .IsRequired()
                    .HasColumnName("NameFA")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportFile).HasMaxLength(50);

                entity.Property(e => e.WebMehod).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportParameter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnumerationTextEn)
                    .HasColumnName("EnumerationTextEN")
                    .HasMaxLength(500);

                entity.Property(e => e.EnumerationTextFa)
                    .HasColumnName("EnumerationTextFA")
                    .HasMaxLength(1000);

                entity.Property(e => e.LabelTextEn)
                    .HasColumnName("LabelTextEN")
                    .HasMaxLength(50);

                entity.Property(e => e.LableTextFa)
                    .IsRequired()
                    .HasColumnName("LableTextFA")
                    .HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportParameter)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportParameter_Report");
            });

            modelBuilder.Entity<ReportRequiredField>(entity =>
            {
                entity.HasKey(e => e.RequiredFiledId);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FieldType).HasMaxLength(50);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportRequiredField)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_ReportRequiredField_Report");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ_Role_roleName")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Removeable).HasColumnName("removeable");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("roleName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SealingParty>(entity =>
            {
                entity.HasKey(e => e.SealingPartyCode);

                entity.HasIndex(e => e.Name)
                    .HasName("UQ_SealingParty_name")
                    .IsUnique();

                entity.Property(e => e.SealingPartyCode)
                    .HasColumnName("sealingPartyCode")
                    .HasColumnType("char(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.ServiceId)
                    .HasColumnName("serviceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ServiceLog>(entity =>
            {
                entity.HasIndex(e => e.ServiceId)
                    .HasName("IX_ServiceLog_Service");

                entity.HasIndex(e => new { e.WebMethod, e.Result, e.ServiceId, e.Operator })
                    .HasName("IX_ServiceLog_ServiceId_Result_Operator");

                entity.HasIndex(e => new { e.WebMethod, e.Result, e.ServiceId, e.ResponseTime, e.Operator })
                    .HasName("IX_ServiceLog_ServiceId_Result_LogId_ResponseTime_Operator");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.Operator).HasColumnName("operator");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("responseTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.Property(e => e.WebMethod)
                    .HasColumnName("webMethod")
                    .HasMaxLength(500);

                entity.HasOne(d => d.ResultNavigation)
                    .WithMany(p => p.ServiceLog)
                    .HasForeignKey(d => d.Result)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLog_ServiceResult");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceLog)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLog_Service");
            });

            modelBuilder.Entity<ServiceResult>(entity =>
            {
                entity.Property(e => e.ServiceResultId)
                    .HasColumnName("serviceResultID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.HasIndex(e => e.ShipName)
                    .HasName("IX_ShipName");

                entity.Property(e => e.BuiltYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CallSign)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Dwt)
                    .HasColumnName("DWT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Grt)
                    .HasColumnName("GRT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Loa)
                    .HasColumnName("LOA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NationalityCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nrt)
                    .HasColumnName("NRT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ShipCode).HasMaxLength(50);

                entity.Property(e => e.ShipImo)
                    .HasColumnName("ShipIMO")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipName).HasMaxLength(250);

                entity.Property(e => e.ShipType).HasMaxLength(50);

                entity.Property(e => e.TotalTeu).HasColumnName("TotalTEU");

                entity.HasOne(d => d.ShippingVessel)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShippingVesselId)
                    .HasConstraintName("FK_Ship_Shipping");
            });

            modelBuilder.Entity<Shipping>(entity =>
            {
                entity.Property(e => e.ShippingId).HasColumnName("shippingID");

                entity.Property(e => e.Abbreviation).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.EconomicCode).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Manager)
                    .HasColumnName("manager")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalCode).HasMaxLength(50);

                entity.Property(e => e.PersianName).HasMaxLength(500);

                entity.Property(e => e.PostalCode).HasMaxLength(100);

                entity.Property(e => e.ShippingCode).HasMaxLength(50);

                entity.Property(e => e.Tell)
                    .HasColumnName("tell")
                    .HasMaxLength(20);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ShippingAgent>(entity =>
            {
                entity.HasKey(e => new { e.ShippingId, e.UserId });

                entity.Property(e => e.ShippingId).HasColumnName("shippingID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Shipping)
                    .WithMany(p => p.ShippingAgent)
                    .HasForeignKey(d => d.ShippingId)
                    .HasConstraintName("FK_ShippingAgent_Shipping");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShippingAgent)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ShippingAgent_User");
            });

            modelBuilder.Entity<ShippingLine>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.HasIndex(e => new { e.LineName, e.ShippingId, e.LineId })
                    .HasName("_dta_index_ShippingLine_7_1020582724__K5_K1_3");

                entity.Property(e => e.Abbreviation).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasColumnType("char(2)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.LineCode).HasMaxLength(50);

                entity.Property(e => e.LineName).HasMaxLength(500);

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.HasOne(d => d.Shipping)
                    .WithMany(p => p.ShippingLine)
                    .HasForeignKey(d => d.ShippingId)
                    .HasConstraintName("FK_ShippingLine_Shipping");
            });

            modelBuilder.Entity<ShipShare>(entity =>
            {
                entity.Property(e => e.ShipShareId).HasColumnName("ShipShareID");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imo)
                    .HasColumnName("IMO")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.ShippingParentId).HasColumnName("ShippingParentID");

                entity.Property(e => e.VesselName).HasMaxLength(150);

                entity.Property(e => e.VoyageNumber).HasMaxLength(150);
            });

            modelBuilder.Entity<SlotSharing>(entity =>
            {
                entity.HasIndex(e => new { e.ShippingLineId, e.Id })
                    .HasName("_dta_index_SlotSharing_7_1952062040__K6_K1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArrivalId).HasColumnName("ArrivalID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Impdep).HasColumnName("IMPDEP");

                entity.Property(e => e.Isopen).HasColumnName("ISopen");

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e._20full).HasColumnName("_20Full");

                entity.Property(e => e._20mt).HasColumnName("_20MT");

                entity.Property(e => e._40full).HasColumnName("_40Full");

                entity.Property(e => e._40mt).HasColumnName("_40MT");

                entity.HasOne(d => d.Arrival)
                    .WithMany(p => p.SlotSharing)
                    .HasForeignKey(d => d.ArrivalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SlotSharing_ArrivalNotice");

                entity.HasOne(d => d.ImpdepNavigation)
                    .WithMany(p => p.SlotSharing)
                    .HasForeignKey(d => d.Impdep)
                    .HasConstraintName("FK_SlotSharing_Types");

                entity.HasOne(d => d.ShippingLine)
                    .WithMany(p => p.SlotSharing)
                    .HasForeignKey(d => d.ShippingLineId)
                    .HasConstraintName("FK_SlotSharing_ShippingLine");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direction).HasColumnType("char(1)");

                entity.Property(e => e.DockId).HasColumnName("DockID");

                entity.HasOne(d => d.Dock)
                    .WithMany(p => p.Station)
                    .HasForeignKey(d => d.DockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Station_Dock");
            });

            modelBuilder.Entity<StoredProcedureLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.StoredProcedureName).HasMaxLength(50);
            });

            modelBuilder.Entity<TaxExemption>(entity =>
            {
                entity.Property(e => e.TaxExemptionDateCreate).HasColumnType("datetime");

                entity.Property(e => e.TaxExemptionDateFrom).HasColumnType("datetime");

                entity.Property(e => e.TaxExemptionDateModify).HasColumnType("datetime");

                entity.Property(e => e.TaxExemptionDateTo).HasColumnType("datetime");

                entity.Property(e => e.TaxExemptionDescription).HasMaxLength(1500);

                entity.Property(e => e.TaxExemptionName).HasMaxLength(500);

                entity.Property(e => e.TaxExemptionNumber).HasMaxLength(50);

                entity.Property(e => e.TaxExemptionPortCode).HasMaxLength(5);
            });

            modelBuilder.Entity<Thctariff>(entity =>
            {
                entity.HasKey(e => e.TariffId);

                entity.ToTable("THCTariff");

                entity.Property(e => e.TariffId).HasColumnName("Tariff_ID");

                entity.Property(e => e.ContainerSize).HasMaxLength(100);

                entity.Property(e => e.ContainerStatus).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.EntryType).HasMaxLength(100);

                entity.Property(e => e.TariffRate).HasColumnName("Tariff_Rate");
            });

            modelBuilder.Entity<ThctariffMove>(entity =>
            {
                entity.HasKey(e => e.ThcmoveId);

                entity.ToTable("THCTariffMove");

                entity.Property(e => e.ThcmoveId).HasColumnName("THCMoveId");

                entity.Property(e => e.ClassType).HasMaxLength(100);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ThcmovePercent).HasColumnName("THCMovePercent");
            });

            modelBuilder.Entity<ThctarrifDetail>(entity =>
            {
                entity.HasKey(e => e.ThcId);

                entity.ToTable("THCTarrifDetail");

                entity.Property(e => e.ThcId).HasColumnName("THC_ID");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DomainName).HasMaxLength(150);

                entity.Property(e => e.FarsiName).HasMaxLength(150);

                entity.Property(e => e.Ispercent).HasColumnName("ISPercent");

                entity.Property(e => e.ThcName)
                    .HasColumnName("THC_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(150);
            });

            modelBuilder.Entity<ThctarrifMain>(entity =>
            {
                entity.HasKey(e => e.Mtid);

                entity.ToTable("THCTarrifMain");

                entity.Property(e => e.Mtid).HasColumnName("MTID");

                entity.Property(e => e.Mtdescription)
                    .HasColumnName("MTDescription")
                    .HasMaxLength(1500);

                entity.Property(e => e.MtfromDate)
                    .HasColumnName("MTFromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mtname)
                    .HasColumnName("MTName")
                    .HasMaxLength(500);

                entity.Property(e => e.Mtstatus).HasColumnName("MTStatus");

                entity.Property(e => e.MttoDate)
                    .HasColumnName("MTToDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Day).HasColumnType("nchar(10)");

                entity.Property(e => e.Time1)
                    .HasColumnName("Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TrackingObjects>(entity =>
            {
                entity.HasKey(e => e.TrackingId);

                entity.HasIndex(e => e.TrackingId)
                    .HasName("IX_TrackingObjects")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntityId, e.OperationTypeId, e.EntityTypeId })
                    .HasName("IX_TrackingObjects_1");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.TypeFarsi).HasMaxLength(500);

                entity.Property(e => e.TypeKey).HasMaxLength(100);

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.Types)
                    .HasForeignKey(d => d.DomainId)
                    .HasConstraintName("FKl_TableTypes_Domain");
            });

            modelBuilder.Entity<Uipage>(entity =>
            {
                entity.ToTable("UIPage");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username)
                    .HasName("UQ_User_username")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birthDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CellPhone)
                    .HasColumnName("cellPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<UserConfig>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginDateBetweenHour).HasMaxLength(10);

                entity.Property(e => e.LoginDateSelectedDayWeek).HasMaxLength(100);

                entity.Property(e => e.PasswordChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.PasswordLength).HasMaxLength(10);
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId });

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UserGroup)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_UserGroup_Group");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroup)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserGroup_User");
            });

            modelBuilder.Entity<UserPasswordHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.OldPassword).HasMaxLength(250);
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.OperationId });

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermission)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserPermission_User");
            });

            modelBuilder.Entity<VesselMovementPosition>(entity =>
            {
                entity.Property(e => e.VesselMovementPositionId).HasColumnName("VesselMovementPositionID");

                entity.Property(e => e.LocationName).HasMaxLength(50);

                entity.Property(e => e.PositionLeft).HasColumnName("Position_Left");

                entity.Property(e => e.PositionTop).HasColumnName("Position_Top");
            });

            modelBuilder.Entity<Voyage>(entity =>
            {
                entity.HasIndex(e => e.Eta)
                    .HasName("IX_VoyageETA");

                entity.HasIndex(e => e.ShippingId)
                    .HasName("IX_VoyageShipping");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_VoyageType");

                entity.HasIndex(e => e.VesselName)
                    .HasName("IX_VoyageVessel");

                entity.HasIndex(e => new { e.VoyageNumber, e.VesselName, e.VoyageId })
                    .HasName("_dta_index_Voyage_Test");

                entity.HasIndex(e => new { e.TypeId, e.Eta, e.VoyageId, e.ShippingAgent })
                    .HasName("_dta_index_Voyage_7_1373963971__K20_K13_K1_K7");

                entity.HasIndex(e => new { e.TypeId, e.VoyageId, e.Eta, e.ShippingAgent })
                    .HasName("_dta_index_Voyage_7_1373963971__K20_K1_K13_K7");

                entity.HasIndex(e => new { e.VoyageNumber, e.VesselName, e.Eta, e.VoyageId, e.TypeId, e.IsEnabled })
                    .HasName("_dta_index_Voyage_7_1373963971__K13_K1_K20_K17_2_8");

                entity.Property(e => e.VoyageId).HasColumnName("voyageID");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrivalTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BerthTime)
                    .HasColumnName("berthTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingNumber)
                    .HasColumnName("bookingNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.DateModifyVoyage).HasColumnType("datetime");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("departureDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etd)
                    .HasColumnName("ETD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("char(2)");

                entity.Property(e => e.OverTime).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.PortOfDischargeId)
                    .IsRequired()
                    .HasColumnName("portOfDischargeID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.PortOfLoadingId)
                    .IsRequired()
                    .HasColumnName("portOfLoadingID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.ShippingAgent)
                    .HasColumnName("shippingAgent")
                    .HasMaxLength(300);

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.ShippingLine)
                    .HasColumnName("shippingLine")
                    .HasMaxLength(300);

                entity.Property(e => e.VesselName)
                    .HasColumnName("vesselName")
                    .HasMaxLength(50);

                entity.Property(e => e.VesselType).HasColumnName("vesselType");

                entity.Property(e => e.VoyageNumber)
                    .HasColumnName("voyageNumber")
                    .HasMaxLength(50);

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.Voyage)
                    .HasForeignKey(d => d.Nationality)
                    .HasConstraintName("FK_Voyage_Country");
            });

            modelBuilder.Entity<WebConfigAppSettings>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("WebConfig_AppSettings");

                entity.Property(e => e.Key)
                    .HasColumnName("Key_")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("ProjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });
        }
    }
}
