﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace iRentApi.Migrations
{
    [DbContext(typeof(IRentContext))]
    [Migration("20230921044626_RentedWarehouse_Prices_Update")]
    partial class RentedWarehouse_Prices_Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Model.Entity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ioc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.ContractModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("Actived")
                        .HasColumnType("bit");

                    b.Property<string>("Base64")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RentedWarehouseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RentedWarehouseId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.RentedWarehouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<decimal>("Confirm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ConfirmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContractBase64")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Deposit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("RenterId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("WarehouseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RenterId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("RentedWarehouses");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.Warehouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<int>("Floors")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int>("Ward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("WarehouseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseComment");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseCommentLike", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CommentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("WarehouseCommentLikes");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("WarehouseId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId1");

                    b.ToTable("WarehouseImages");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.ContractModel", b =>
                {
                    b.HasOne("iRentApi.Model.Entity.RentedWarehouse", "RentedWarehouse")
                        .WithMany()
                        .HasForeignKey("RentedWarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentedWarehouse");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.RentedWarehouse", b =>
                {
                    b.HasOne("Domain.Model.Entity.User", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.HasOne("iRentApi.Model.Entity.Warehouse", "Warehouse")
                        .WithMany("RentedWarehouses")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Renter");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.Warehouse", b =>
                {
                    b.HasOne("Domain.Model.Entity.User", "User")
                        .WithMany("Warehouses")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseComment", b =>
                {
                    b.HasOne("Domain.Model.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("iRentApi.Model.Entity.Warehouse", "Warehouse")
                        .WithMany("Comments")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseCommentLike", b =>
                {
                    b.HasOne("iRentApi.Model.Entity.WarehouseComment", "Comment")
                        .WithMany("CommentLikes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Model.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseImage", b =>
                {
                    b.HasOne("iRentApi.Model.Entity.Warehouse", "Warehouse")
                        .WithMany("Images")
                        .HasForeignKey("WarehouseId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Domain.Model.Entity.User", b =>
                {
                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.Warehouse", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("RentedWarehouses");
                });

            modelBuilder.Entity("iRentApi.Model.Entity.WarehouseComment", b =>
                {
                    b.Navigation("CommentLikes");
                });
#pragma warning restore 612, 618
        }
    }
}
