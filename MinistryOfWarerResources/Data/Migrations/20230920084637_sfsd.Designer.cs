﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinistryOfWarerResources.Data;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230920084637_sfsd")]
    partial class sfsd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Id = "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                            ConcurrencyStamp = "8c88e40b-77a1-492b-9ec6-c8ac990a8fc2",
                            Name = "owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "asdasdasasdadda",
                            ConcurrencyStamp = "6d030614-3543-4fac-af76-f9131c1287cf",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "asdasdasdasasasdadda",
                            ConcurrencyStamp = "58be0e08-6fac-49fd-9774-6b7b64b628cd",
                            Name = "DawaView",
                            NormalizedName = "DAWAVIEW"
                        },
                        new
                        {
                            Id = "asdfadaczxcsfhdfd",
                            ConcurrencyStamp = "1ef85120-755c-4752-b66c-d9db26641052",
                            Name = "eatalaJazaea",
                            NormalizedName = "EATALAJAZAEA"
                        },
                        new
                        {
                            Id = "asdfadaczsdsdsdsdxcsfhdfd",
                            ConcurrencyStamp = "2da0b972-c97d-4ce9-832d-23596cb914bc",
                            Name = "admin2",
                            NormalizedName = "ADMIN2"
                        },
                        new
                        {
                            Id = "asdasadadaddacsdadda",
                            ConcurrencyStamp = "2e537ffe-6c9e-43c0-aad1-ae6e1d03a9b8",
                            Name = "regulator",
                            NormalizedName = "REGULATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc1580ac-9728-42aa-96ba-06cc3d51f26b",
                            Email = "admin",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin",
                            NormalizedUserName = "admin",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8193b80b-74e2-4a99-98d4-6b70ac6a106b",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "cvfgrtbvdscvfd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd6a95a8-f312-4533-9d17-a06076d71f8f",
                            Email = "admin",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin",
                            NormalizedUserName = "ADMIN2",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bf3ed04c-b5b7-4e29-8f80-67a8b6441bb7",
                            TwoFactorEnabled = false,
                            UserName = "admin2"
                        },
                        new
                        {
                            Id = "dASDadadasdasdasdsa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de5f101a-c99e-4266-b021-46c546f95879",
                            Email = "owner",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "owner",
                            NormalizedUserName = "OWNER",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6ecb2aeb-f548-42b8-9538-82e9b7739c68",
                            TwoFactorEnabled = false,
                            UserName = "owner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            RoleId = "oi2eoij-1oqjsdkj-kaslk-OwnerRole"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MinistryOfWarerResources.Models.DaawaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AkherALajraaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AstanafNO")
                        .HasColumnType("int");

                    b.Property<string>("Court")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1Num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectDawa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TameezNO")
                        .HasColumnType("int");

                    b.Property<int>("TashehNO")
                        .HasColumnType("int");

                    b.Property<int>("qraraadaNO")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DawwaTable");
                });

            modelBuilder.Entity("MinistryOfWarerResources.Models.JazaeaModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AkherALajraaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AstanafNO")
                        .HasColumnType("int");

                    b.Property<string>("Court")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1Num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectDawa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TameezNO")
                        .HasColumnType("int");

                    b.Property<int>("TashehNO")
                        .HasColumnType("int");

                    b.Property<int>("qraraadaNO")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JazaeaTable");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
