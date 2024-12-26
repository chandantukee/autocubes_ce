using System;
using System.Collections.Generic;
using AutoCubes.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace AutoCubes.Infrastructure.Context;

public partial class AutoCubesDbContext : DbContext
{
    public AutoCubesDbContext()
    {
    }

    public AutoCubesDbContext(DbContextOptions<AutoCubesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminDealer> AdminDealers { get; set; }

    public virtual DbSet<AdminLocation> AdminLocations { get; set; }

    public virtual DbSet<AdminOrganization> AdminOrganizations { get; set; }

    public virtual DbSet<AdminOrganizationType> AdminOrganizationTypes { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<FactPurchaseOrder> FactPurchaseOrders { get; set; }

    public virtual DbSet<FactPurchaseOrderDetail> FactPurchaseOrderDetails { get; set; }

    public virtual DbSet<ICity> ICities { get; set; }

    public virtual DbSet<ICompanyType> ICompanyTypes { get; set; }

    public virtual DbSet<ICountry> ICountries { get; set; }

    public virtual DbSet<IItemCategory> IItemCategories { get; set; }

    public virtual DbSet<IItemType> IItemTypes { get; set; }

    public virtual DbSet<IProcess> IProcesses { get; set; }

    public virtual DbSet<IRole> IRoles { get; set; }

    public virtual DbSet<IRolePermission> IRolePermissions { get; set; }

    public virtual DbSet<ISaleType> ISaleTypes { get; set; }

    public virtual DbSet<IScreen> IScreens { get; set; }

    public virtual DbSet<IStage> IStages { get; set; }

    public virtual DbSet<IState> IStates { get; set; }

    public virtual DbSet<IUnitOfMeasurement> IUnitOfMeasurements { get; set; }

    public virtual DbSet<MasterBin> MasterBins { get; set; }

    public virtual DbSet<MasterDesignation> MasterDesignations { get; set; }

    public virtual DbSet<MasterItemPrice> MasterItemPrices { get; set; }

    public virtual DbSet<MasterSupplier> MasterSuppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AdminDealer>(entity =>
        {
            entity.HasKey(e => e.DealerId).HasName("PRIMARY");

            entity.ToTable("admin_dealer");

            entity.Property(e => e.Cin)
                .HasMaxLength(15)
                .HasColumnName("CIN");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DealerAlias).HasMaxLength(45);
            entity.Property(e => e.DealerCode).HasMaxLength(45);
            entity.Property(e => e.DealerContactPerson).HasMaxLength(255);
            entity.Property(e => e.DealerCreditValue).HasPrecision(18, 2);
            entity.Property(e => e.DealerEmail).HasMaxLength(255);
            entity.Property(e => e.DealerMobile).HasMaxLength(10);
            entity.Property(e => e.DealerPincode).HasMaxLength(6);
            entity.Property(e => e.Gstin)
                .HasMaxLength(15)
                .HasColumnName("GSTIN");
            entity.Property(e => e.Iec)
                .HasMaxLength(10)
                .HasColumnName("IEC");
            entity.Property(e => e.Pan)
                .HasMaxLength(10)
                .HasColumnName("PAN");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdminLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("admin_location");

            entity.Property(e => e.LocationAlias).HasMaxLength(45);
            entity.Property(e => e.LocationCode).HasMaxLength(45);
            entity.Property(e => e.LocationContactPerson).HasMaxLength(255);
            entity.Property(e => e.LocationEmail).HasMaxLength(255);
            entity.Property(e => e.LocationName).HasMaxLength(255);
            entity.Property(e => e.LocationPhone).HasMaxLength(10);
            entity.Property(e => e.LocationPincode).HasMaxLength(6);
            entity.Property(e => e.LocationType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("W - Warehouse; O - Office; B - Both");
        });

        modelBuilder.Entity<AdminOrganization>(entity =>
        {
            entity.HasKey(e => e.OrganizationId).HasName("PRIMARY");

            entity.ToTable("admin_organization");

            entity.HasIndex(e => e.OrganizationCode, "OrganizationCode_UNIQUE").IsUnique();

            entity.HasIndex(e => e.OrganizationTypeId, "OrganizationTypeFK_idx");

            entity.Property(e => e.Cin)
                .HasMaxLength(15)
                .HasColumnName("CIN");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Gstin)
                .HasMaxLength(15)
                .HasComment("^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$")
                .HasColumnName("GSTIN");
            entity.Property(e => e.Iec)
                .HasMaxLength(10)
                .HasComment("([A-Z]){5}([0-9]){4}([A-Z]){1}$")
                .HasColumnName("IEC");
            entity.Property(e => e.OrganizationAlias).HasMaxLength(45);
            entity.Property(e => e.OrganizationCode).HasMaxLength(45);
            entity.Property(e => e.OrganizationContactPerson).HasMaxLength(255);
            entity.Property(e => e.OrganizationEmail).HasMaxLength(255);
            entity.Property(e => e.OrganizationMobile).HasMaxLength(10);
            entity.Property(e => e.OrganizationPincode).HasMaxLength(6);
            entity.Property(e => e.Pan)
                .HasMaxLength(10)
                .HasComment("([A-Z]){5}([0-9]){4}([A-Z]){1}$")
                .HasColumnName("PAN");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.OrganizationType).WithMany(p => p.AdminOrganizations)
                .HasForeignKey(d => d.OrganizationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OrganizationTypeFK");
        });

        modelBuilder.Entity<AdminOrganizationType>(entity =>
        {
            entity.HasKey(e => e.OrganizationTypeId).HasName("PRIMARY");

            entity.ToTable("admin_organization_type");

            entity.HasIndex(e => e.OrganizationTypeName, "OrganizationType_UNIQUE").IsUnique();

            entity.Property(e => e.OrganizationTypeName).HasMaxLength(45);
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("admin_user");

            entity.HasIndex(e => e.DesignationId, "DesignationIdFK_idx");

            entity.HasIndex(e => e.OrganizationId, "OrganizationIdFK_idx");

            entity.HasIndex(e => e.RoleId, "RoleIdFK_idx");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UserEmail).HasMaxLength(255);
            entity.Property(e => e.UserMobile).HasMaxLength(10);
            entity.Property(e => e.UserName).HasMaxLength(45);
            entity.Property(e => e.WhatsAppNumber).HasMaxLength(10);

            entity.HasOne(d => d.Designation).WithMany(p => p.AdminUsers)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DesignationIdFK");

            entity.HasOne(d => d.Organization).WithMany(p => p.AdminUsers)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OrganizationIdFK");
        });

        modelBuilder.Entity<FactPurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderId).HasName("PRIMARY");

            entity.ToTable("fact_purchase_order");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpectedDeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderNo).HasMaxLength(45);
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SupplierOrderValue).HasPrecision(18, 2);
        });

        modelBuilder.Entity<FactPurchaseOrderDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderDetailId).HasName("PRIMARY");

            entity.ToTable("fact_purchase_order_detail");

            entity.HasIndex(e => e.PurchaseOrderId, "PurchaseOrderId");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.FactPurchaseOrderDetails)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fact_purchase_order_detail_ibfk_1");
        });

        modelBuilder.Entity<ICity>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PRIMARY");

            entity.ToTable("i_city");

            entity.Property(e => e.CityName).HasMaxLength(255);
        });

        modelBuilder.Entity<ICompanyType>(entity =>
        {
            entity.HasKey(e => e.CompanyTypeId).HasName("PRIMARY");

            entity.ToTable("i_company_type");

            entity.Property(e => e.CompanyTypeName).HasMaxLength(45);
        });

        modelBuilder.Entity<ICountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PRIMARY");

            entity.ToTable("i_country");

            entity.HasIndex(e => e.CountryCode, "CountryCode_UNIQUE").IsUnique();

            entity.HasIndex(e => e.CountryName, "CountryName_UNIQUE").IsUnique();

            entity.Property(e => e.CountryAlias).HasMaxLength(45);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasComment("IND356");
            entity.Property(e => e.CountryStatus).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<IItemCategory>(entity =>
        {
            entity.HasKey(e => e.ItemCategoryId).HasName("PRIMARY");

            entity.ToTable("i_item_category");

            entity.Property(e => e.ItemCategoryName)
                .HasMaxLength(100)
                .HasComment("HelmetsPaddings/Visors/PinLock");
        });

        modelBuilder.Entity<IItemType>(entity =>
        {
            entity.HasKey(e => e.ItemTypeId).HasName("PRIMARY");

            entity.ToTable("i_item_type");

            entity.Property(e => e.ItemTypeCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasComment("P - Product; S - Service");
        });

        modelBuilder.Entity<IProcess>(entity =>
        {
            entity.HasKey(e => e.ProcessId).HasName("PRIMARY");

            entity.ToTable("i_process");

            entity.Property(e => e.ProcessName).HasMaxLength(45);
            entity.Property(e => e.ProcessStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'")
                .IsFixedLength()
                .HasComment("A-Active;I-InActive");
        });

        modelBuilder.Entity<IRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.ToTable("i_role");

            entity.HasIndex(e => e.RoleName, "RoleName_UNIQUE").IsUnique();

            entity.Property(e => e.RoleName).HasMaxLength(45);
        });

        modelBuilder.Entity<IRolePermission>(entity =>
        {
            entity.HasKey(e => e.RolePermissionId).HasName("PRIMARY");

            entity.ToTable("i_role_permission");

            entity.HasIndex(e => e.RoleId, "RoleIdFK_idx");

            entity.HasIndex(e => e.ScreenId, "ScreenIdFK_idx");

            entity.HasOne(d => d.Role).WithMany(p => p.IRolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RoleIdFK");

            entity.HasOne(d => d.Screen).WithMany(p => p.IRolePermissions)
                .HasForeignKey(d => d.ScreenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ScreenIdFK");
        });

        modelBuilder.Entity<ISaleType>(entity =>
        {
            entity.HasKey(e => e.SaleTypeId).HasName("PRIMARY");

            entity.ToTable("i_sale_type");

            entity.Property(e => e.Gstrequired).HasColumnName("GSTRequired");
            entity.Property(e => e.SaleTypeName)
                .HasMaxLength(45)
                .HasComment("B2B; B2C");
        });

        modelBuilder.Entity<IScreen>(entity =>
        {
            entity.HasKey(e => e.ScreenId).HasName("PRIMARY");

            entity.ToTable("i_screen");

            entity.Property(e => e.ScreenName).HasMaxLength(255);
            entity.Property(e => e.ScreenSlug).HasMaxLength(255);
        });

        modelBuilder.Entity<IStage>(entity =>
        {
            entity.HasKey(e => e.StageId).HasName("PRIMARY");

            entity.ToTable("i_stage");

            entity.Property(e => e.StageName).HasMaxLength(45);
        });

        modelBuilder.Entity<IState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PRIMARY");

            entity.ToTable("i_state");

            entity.HasIndex(e => e.CountryId, "CountryFK_idx");

            entity.Property(e => e.StateCode).HasMaxLength(2);
            entity.Property(e => e.StateName).HasMaxLength(255);

            entity.HasOne(d => d.Country).WithMany(p => p.IStates)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_country");
        });

        modelBuilder.Entity<IUnitOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.Uomid).HasName("PRIMARY");

            entity.ToTable("i_unit_of_measurement");

            entity.Property(e => e.Uomid).HasColumnName("UOMId");
            entity.Property(e => e.BaseUomid).HasColumnName("BaseUOMId");
            entity.Property(e => e.ConversionFactor).HasMaxLength(45);
            entity.Property(e => e.IsBaseUom).HasColumnName("IsBaseUOM");
            entity.Property(e => e.Uomcode)
                .HasMaxLength(45)
                .HasColumnName("UOMCode");
            entity.Property(e => e.Uomname)
                .HasMaxLength(45)
                .HasColumnName("UOMName");
        });

        modelBuilder.Entity<MasterBin>(entity =>
        {
            entity.HasKey(e => e.BinId).HasName("PRIMARY");

            entity.ToTable("master_bin");

            entity.Property(e => e.BinName).HasMaxLength(45);
        });

        modelBuilder.Entity<MasterDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PRIMARY");

            entity.ToTable("master_designation");

            entity.Property(e => e.DesignationName).HasMaxLength(100);
        });

        modelBuilder.Entity<MasterItemPrice>(entity =>
        {
            entity.HasKey(e => e.ItemPriceId).HasName("PRIMARY");

            entity.ToTable("master_item_price");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Mrp)
                .HasPrecision(18, 2)
                .HasColumnName("MRP");
            entity.Property(e => e.TaxValue).HasPrecision(18, 2);
            entity.Property(e => e.UnitPrice).HasPrecision(18, 2);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<MasterSupplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");

            entity.ToTable("master_supplier");

            entity.Property(e => e.Cin)
                .HasMaxLength(15)
                .HasColumnName("CIN");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Gstin)
                .HasMaxLength(15)
                .HasColumnName("GSTIN");
            entity.Property(e => e.Iec)
                .HasMaxLength(10)
                .HasColumnName("IEC");
            entity.Property(e => e.Pan)
                .HasMaxLength(10)
                .HasColumnName("PAN");
            entity.Property(e => e.SupplierAlias).HasMaxLength(45);
            entity.Property(e => e.SupplierCode).HasMaxLength(45);
            entity.Property(e => e.SupplierContactPerson).HasMaxLength(255);
            entity.Property(e => e.SupplierEmail).HasMaxLength(255);
            entity.Property(e => e.SupplierMobile).HasMaxLength(10);
            entity.Property(e => e.SupplierPincode).HasMaxLength(6);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
