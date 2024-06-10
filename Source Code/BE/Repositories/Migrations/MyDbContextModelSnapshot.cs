﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8b516022-520d-4bb7-bf7b-dcd1c23f8465",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "20936102-504f-4787-bc3b-810be16f6914",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "d423646f-2ab4-4430-83fc-1c385c077d0b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Repositories.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BlogID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ManagerID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("BlogId")
                        .HasName("PK__Blog__54379E50328EC178");

                    b.HasIndex("ManagerId");

                    b.ToTable("Blog", (string)null);
                });

            modelBuilder.Entity("Repositories.Design", b =>
                {
                    b.Property<int>("DesignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DesignID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesignName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ManagerID");

                    b.Property<int?>("MasterGemstoneId")
                        .HasColumnType("int")
                        .HasColumnName("MasterGemstoneID");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<int?>("StoneId")
                        .HasColumnType("int")
                        .HasColumnName("StoneID");

                    b.Property<int>("TypeOfJewelleryId")
                        .HasColumnType("int")
                        .HasColumnName("TypeOfJewelleryID");

                    b.Property<decimal?>("WeightOfMaterial")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("DesignId")
                        .HasName("PK__Design__32B8E17FAAEB8C8B");

                    b.HasIndex("ManagerId");

                    b.HasIndex("MasterGemstoneId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ParentId");

                    b.HasIndex("StoneId");

                    b.HasIndex("TypeOfJewelleryId");

                    b.ToTable("Design", (string)null);
                });

            modelBuilder.Entity("Repositories.DesignRule", b =>
                {
                    b.Property<int>("DesignRuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignRuleId"));

                    b.Property<decimal?>("MaxSizeJewellery")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("MaxSizeMasterGemstone")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("MinSizeJewellery")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("MinSizeMasterGemstone")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("TypeOfJewelleryId")
                        .HasColumnType("int")
                        .HasColumnName("TypeOfJewelleryID");

                    b.HasKey("DesignRuleId")
                        .HasName("PK__DesignRu__3850E3634E9D1DEE");

                    b.HasIndex("TypeOfJewelleryId");

                    b.ToTable("DesignRule", (string)null);
                });

            modelBuilder.Entity("Repositories.Entity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Repositories.Have", b =>
                {
                    b.Property<int>("WarrantyCardId")
                        .HasColumnType("int")
                        .HasColumnName("WarrantyCardID");

                    b.Property<int>("RequirementId")
                        .HasColumnType("int")
                        .HasColumnName("RequirementID");

                    b.Property<DateOnly?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("ExpirationDate")
                        .HasColumnType("date");

                    b.HasKey("WarrantyCardId", "RequirementId")
                        .HasName("PK__Have__FBE292CD11001214");

                    b.HasIndex("RequirementId");

                    b.ToTable("Have", (string)null);
                });

            modelBuilder.Entity("Repositories.MasterGemstone", b =>
                {
                    b.Property<int>("MasterGemstoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MasterGemstoneID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MasterGemstoneId"));

                    b.Property<string>("Clarity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cut")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Kind")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Shape")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Size")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("MasterGemstoneId")
                        .HasName("PK__MasterGe__D4657CE325820E1C");

                    b.ToTable("MasterGemstone", (string)null);
                });

            modelBuilder.Entity("Repositories.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"));

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ManagerID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("MaterialId")
                        .HasName("PK__Material__C506131755BDA89F");

                    b.HasIndex("ManagerId");

                    b.ToTable("Material", (string)null);
                });

            modelBuilder.Entity("Repositories.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Method")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("RequirementsId")
                        .HasColumnType("int")
                        .HasColumnName("RequirementsID");

                    b.HasKey("PaymentId")
                        .HasName("PK__Payment__9B556A584CDCE2CF");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RequirementsId");

                    b.ToTable("Payment", (string)null);
                });

            modelBuilder.Entity("Repositories.Requirement", b =>
                {
                    b.Property<int>("RequirementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RequirementID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequirementId"));

                    b.Property<string>("CustomerNote")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Design3D")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("DesignId")
                        .HasColumnType("int")
                        .HasColumnName("DesignID");

                    b.Property<DateOnly?>("ExpectedDelivery")
                        .HasColumnType("date");

                    b.Property<decimal?>("GoldPriceAtMoment")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("MachiningFee")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Size")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("StaffNote")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Status")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("StonePriceAtMoment")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("TotalMoney")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("RequirementId")
                        .HasName("PK__Requirem__7DF11E7DA4E2ED57");

                    b.HasIndex("DesignId");

                    b.ToTable("Requirements");
                });

            modelBuilder.Entity("Repositories.Stones", b =>
                {
                    b.Property<int>("StonesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StoneID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StonesId"));

                    b.Property<string>("Kind")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("Size")
                        .HasMaxLength(255)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StonesId")
                        .HasName("PK__Stones__59F240A0F68BB9CA");

                    b.ToTable("Stones");
                });

            modelBuilder.Entity("Repositories.TypeOfJewellery", b =>
                {
                    b.Property<int>("TypeOfJewelleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TypeOfJewelleryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeOfJewelleryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TypeOfJewelleryId")
                        .HasName("PK__TypeOfJe__F1D25D48390D573D");

                    b.ToTable("TypeOfJewellery", (string)null);
                });

            modelBuilder.Entity("Repositories.UserRequirement", b =>
                {
                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("UsersID");

                    b.Property<int>("RequirementId")
                        .HasColumnType("int")
                        .HasColumnName("RequirementID");

                    b.HasKey("UsersId", "RequirementId")
                        .HasName("PK__UsersReq__EC83D35F40A575F1");

                    b.HasIndex("RequirementId");

                    b.ToTable("UsersRequirement", (string)null);
                });

            modelBuilder.Entity("Repositories.WarrantyCard", b =>
                {
                    b.Property<int>("WarrantyCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WarrantyCardID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarrantyCardId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("WarrantyCardId")
                        .HasName("PK__Warranty__3C3D832A529B2241");

                    b.ToTable("WarrantyCard", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repositories.Blog", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", "Manager")
                        .WithMany("Blogs")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK__Blog__ManagerID__3C69FB99");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Repositories.Design", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", "Manager")
                        .WithMany("Designs")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK__Design__ManagerI__4AB81AF0");

                    b.HasOne("Repositories.MasterGemstone", "MasterGemstone")
                        .WithMany("Designs")
                        .HasForeignKey("MasterGemstoneId")
                        .HasConstraintName("FK__Design__MasterGe__49C3F6B7");

                    b.HasOne("Repositories.Material", "Material")
                        .WithMany("Designs")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("FK__Design__Material__4CA06362");

                    b.HasOne("Repositories.Design", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK__Design__ParentID__47DBAE45");

                    b.HasOne("Repositories.Stones", "Stone")
                        .WithMany("Designs")
                        .HasForeignKey("StoneId")
                        .HasConstraintName("FK__Design__StoneID__48CFD27E");

                    b.HasOne("Repositories.TypeOfJewellery", "TypeOfJewellery")
                        .WithMany("Designs")
                        .HasForeignKey("TypeOfJewelleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Design__TypeOfJe__4BAC3F29");

                    b.Navigation("Manager");

                    b.Navigation("MasterGemstone");

                    b.Navigation("Material");

                    b.Navigation("Parent");

                    b.Navigation("Stone");

                    b.Navigation("TypeOfJewellery");
                });

            modelBuilder.Entity("Repositories.DesignRule", b =>
                {
                    b.HasOne("Repositories.TypeOfJewellery", "TypeOfJewellery")
                        .WithMany("DesignRules")
                        .HasForeignKey("TypeOfJewelleryId")
                        .HasConstraintName("FK__DesignRul__TypeO__5EBF139D");

                    b.Navigation("TypeOfJewellery");
                });

            modelBuilder.Entity("Repositories.Have", b =>
                {
                    b.HasOne("Repositories.Requirement", "Requirement")
                        .WithMany("Haves")
                        .HasForeignKey("RequirementId")
                        .IsRequired()
                        .HasConstraintName("FK__Have__Requiremen__5535A963");

                    b.HasOne("Repositories.WarrantyCard", "WarrantyCard")
                        .WithMany("Haves")
                        .HasForeignKey("WarrantyCardId")
                        .IsRequired()
                        .HasConstraintName("FK__Have__WarrantyCa__5441852A");

                    b.Navigation("Requirement");

                    b.Navigation("WarrantyCard");
                });

            modelBuilder.Entity("Repositories.Material", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", "Manager")
                        .WithMany("Materials")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK__Material__Manage__412EB0B6");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Repositories.Payment", b =>
                {
                    b.HasOne("Repositories.Entity.AppUser", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Payment__Custome__5BE2A6F2");

                    b.HasOne("Repositories.Requirement", "Requirement")
                        .WithMany("Payments")
                        .HasForeignKey("RequirementsId")
                        .HasConstraintName("FK__Payment__Require__5CD6CB2B");

                    b.Navigation("Customer");

                    b.Navigation("Requirement");
                });

            modelBuilder.Entity("Repositories.Requirement", b =>
                {
                    b.HasOne("Repositories.Design", "Design")
                        .WithMany("Requirements")
                        .HasForeignKey("DesignId")
                        .HasConstraintName("FK__Requireme__Desig__4F7CD00D");

                    b.Navigation("Design");
                });

            modelBuilder.Entity("Repositories.UserRequirement", b =>
                {
                    b.HasOne("Repositories.Requirement", "Requirement")
                        .WithMany("UserRequirements")
                        .HasForeignKey("RequirementId")
                        .IsRequired()
                        .HasConstraintName("FK__UsersRequ__Requi__52593CB8");

                    b.HasOne("Repositories.Entity.AppUser", "User")
                        .WithMany("UserRequirements")
                        .HasForeignKey("UsersId")
                        .IsRequired()
                        .HasConstraintName("FK__UsersRequ__Users__5165187F");

                    b.Navigation("Requirement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repositories.Design", b =>
                {
                    b.Navigation("InverseParent");

                    b.Navigation("Requirements");
                });

            modelBuilder.Entity("Repositories.Entity.AppUser", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Designs");

                    b.Navigation("Materials");

                    b.Navigation("Payments");

                    b.Navigation("UserRequirements");
                });

            modelBuilder.Entity("Repositories.MasterGemstone", b =>
                {
                    b.Navigation("Designs");
                });

            modelBuilder.Entity("Repositories.Material", b =>
                {
                    b.Navigation("Designs");
                });

            modelBuilder.Entity("Repositories.Requirement", b =>
                {
                    b.Navigation("Haves");

                    b.Navigation("Payments");

                    b.Navigation("UserRequirements");
                });

            modelBuilder.Entity("Repositories.Stones", b =>
                {
                    b.Navigation("Designs");
                });

            modelBuilder.Entity("Repositories.TypeOfJewellery", b =>
                {
                    b.Navigation("DesignRules");

                    b.Navigation("Designs");
                });

            modelBuilder.Entity("Repositories.WarrantyCard", b =>
                {
                    b.Navigation("Haves");
                });
#pragma warning restore 612, 618
        }
    }
}
