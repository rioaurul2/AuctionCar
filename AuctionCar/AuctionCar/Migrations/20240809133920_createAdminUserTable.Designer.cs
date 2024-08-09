﻿// <auto-generated />
using System;
using AuctionCar.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuctionCar.Migrations
{
    [DbContext(typeof(AuctionCarContext))]
    [Migration("20240809133920_createAdminUserTable")]
    partial class createAdminUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuctionCar.Models.Auction.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("AuctionCar.Models.Auction.AuctionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuctionStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Inactive"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Suspended"
                        },
                        new
                        {
                            Id = 4,
                            Status = "Closed"
                        },
                        new
                        {
                            Id = 5,
                            Status = "Removed"
                        });
                });

            modelBuilder.Entity("AuctionCar.Models.Bid.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LotId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("LotId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.Lot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OriginalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("StatusId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.LotStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LotStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Closed"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Upcoming"
                        },
                        new
                        {
                            Id = 4,
                            Status = "Removed"
                        },
                        new
                        {
                            Id = 5,
                            Status = "PendingApproval"
                        });
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDamaged")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleDetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleDetailsId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.VehicleAccesory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Merchandise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int>("VehicleDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleDetailId");

                    b.ToTable("VehicleAccesories");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.VehicleDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<int>("NoOfDors")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehicleDetails");
                });

            modelBuilder.Entity("AuctionCar.Models.Users.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ResetPasswordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaltPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AuctionCar.Models.Users.Buyer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ResetPasswordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SaltPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("AuctionCar.Models.Auction.Auction", b =>
                {
                    b.HasOne("AuctionCar.Models.Auction.AuctionStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("AuctionCar.Models.Bid.Bid", b =>
                {
                    b.HasOne("AuctionCar.Models.Users.Buyer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionCar.Models.Lot.Lot", "Lot")
                        .WithMany("Bids")
                        .HasForeignKey("LotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Lot");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.Lot", b =>
                {
                    b.HasOne("AuctionCar.Models.Auction.Auction", "Auction")
                        .WithMany("Lots")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionCar.Models.Lot.LotStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("AuctionCar.Models.Lot.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("Status");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.Vehicle", b =>
                {
                    b.HasOne("AuctionCar.Models.Lot.VehicleDetails", "VehicleDetails")
                        .WithMany()
                        .HasForeignKey("VehicleDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleDetails");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.VehicleAccesory", b =>
                {
                    b.HasOne("AuctionCar.Models.Lot.VehicleDetails", "VehicleDetails")
                        .WithMany("VehicleAccesoryes")
                        .HasForeignKey("VehicleDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleDetails");
                });

            modelBuilder.Entity("AuctionCar.Models.Auction.Auction", b =>
                {
                    b.Navigation("Lots");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.Lot", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("AuctionCar.Models.Lot.VehicleDetails", b =>
                {
                    b.Navigation("VehicleAccesoryes");
                });
#pragma warning restore 612, 618
        }
    }
}
