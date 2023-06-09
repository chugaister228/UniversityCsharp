﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesDatabase.Data;

#nullable disable

namespace SalesWeb.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20230506141759_01")]
    partial class _01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesDatabase.Data.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CreditCardNumber = "63049746141772953",
                            Email = "Gerson_Abbott@yahoo.com",
                            Name = "Sonny"
                        },
                        new
                        {
                            CustomerId = 2,
                            CreditCardNumber = "3709-925256-01753",
                            Email = "Briana.Borer47@gmail.com",
                            Name = "Brannon"
                        },
                        new
                        {
                            CustomerId = 3,
                            CreditCardNumber = "6767-6280-1531-9801-89",
                            Email = "Payton.Howell18@yahoo.com",
                            Name = "Rowland"
                        },
                        new
                        {
                            CustomerId = 4,
                            CreditCardNumber = "6767-1898-3803-6803-694",
                            Email = "Angeline.Hackett@gmail.com",
                            Name = "Chelsea"
                        },
                        new
                        {
                            CustomerId = 5,
                            CreditCardNumber = "3649-070130-8257",
                            Email = "Alexa35@hotmail.com",
                            Name = "Trycia"
                        },
                        new
                        {
                            CustomerId = 6,
                            CreditCardNumber = "3029-512461-0189",
                            Email = "Lois65@hotmail.com",
                            Name = "Ethan"
                        },
                        new
                        {
                            CustomerId = 7,
                            CreditCardNumber = "6759-7246-5079-2296-933",
                            Email = "Junior.Senger66@yahoo.com",
                            Name = "Justus"
                        },
                        new
                        {
                            CustomerId = 8,
                            CreditCardNumber = "6011-6241-3363-1874-0816",
                            Email = "Clementine83@hotmail.com",
                            Name = "Bessie"
                        },
                        new
                        {
                            CustomerId = 9,
                            CreditCardNumber = "5018537233701275311",
                            Email = "Jay76@gmail.com",
                            Name = "Preston"
                        },
                        new
                        {
                            CustomerId = 10,
                            CreditCardNumber = "6767-0114-1451-7535-298",
                            Email = "Lindsay.Keebler@gmail.com",
                            Name = "Amir"
                        });
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "Generic Metal Tuna",
                            Price = 4880,
                            Quantity = 5
                        },
                        new
                        {
                            ProductId = 2,
                            Name = "Handmade Frozen Keyboard",
                            Price = 1833,
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 3,
                            Name = "Unbranded Wooden Sausages",
                            Price = 4543,
                            Quantity = 8
                        },
                        new
                        {
                            ProductId = 4,
                            Name = "Tasty Plastic Car",
                            Price = 3999,
                            Quantity = 7
                        },
                        new
                        {
                            ProductId = 5,
                            Name = "Small Steel Table",
                            Price = 1106,
                            Quantity = 6
                        },
                        new
                        {
                            ProductId = 6,
                            Name = "Generic Cotton Pants",
                            Price = 4375,
                            Quantity = 3
                        },
                        new
                        {
                            ProductId = 7,
                            Name = "Fantastic Wooden Car",
                            Price = 478,
                            Quantity = 7
                        },
                        new
                        {
                            ProductId = 8,
                            Name = "Handcrafted Metal Sausages",
                            Price = 2003,
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 9,
                            Name = "Handcrafted Granite Towels",
                            Price = 1339,
                            Quantity = 7
                        },
                        new
                        {
                            ProductId = 10,
                            Name = "Incredible Plastic Gloves",
                            Price = 675,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            CustomerId = 2,
                            Date = new DateTime(2022, 5, 8, 6, 22, 32, 549, DateTimeKind.Local).AddTicks(602),
                            ProductId = 10,
                            StoreId = 4
                        },
                        new
                        {
                            SaleId = 2,
                            CustomerId = 8,
                            Date = new DateTime(2023, 1, 13, 20, 44, 3, 810, DateTimeKind.Local).AddTicks(5455),
                            ProductId = 9,
                            StoreId = 1
                        },
                        new
                        {
                            SaleId = 3,
                            CustomerId = 6,
                            Date = new DateTime(2023, 2, 6, 22, 32, 43, 297, DateTimeKind.Local).AddTicks(6970),
                            ProductId = 6,
                            StoreId = 3
                        },
                        new
                        {
                            SaleId = 4,
                            CustomerId = 9,
                            Date = new DateTime(2023, 3, 10, 17, 23, 43, 616, DateTimeKind.Local).AddTicks(3776),
                            ProductId = 9,
                            StoreId = 10
                        },
                        new
                        {
                            SaleId = 5,
                            CustomerId = 2,
                            Date = new DateTime(2023, 2, 22, 5, 53, 40, 66, DateTimeKind.Local).AddTicks(1480),
                            ProductId = 5,
                            StoreId = 7
                        },
                        new
                        {
                            SaleId = 6,
                            CustomerId = 2,
                            Date = new DateTime(2023, 1, 9, 3, 3, 41, 20, DateTimeKind.Local).AddTicks(1402),
                            ProductId = 6,
                            StoreId = 8
                        },
                        new
                        {
                            SaleId = 7,
                            CustomerId = 8,
                            Date = new DateTime(2022, 6, 11, 9, 32, 22, 336, DateTimeKind.Local).AddTicks(8675),
                            ProductId = 5,
                            StoreId = 2
                        },
                        new
                        {
                            SaleId = 8,
                            CustomerId = 8,
                            Date = new DateTime(2022, 11, 8, 2, 53, 55, 593, DateTimeKind.Local).AddTicks(7394),
                            ProductId = 7,
                            StoreId = 7
                        },
                        new
                        {
                            SaleId = 9,
                            CustomerId = 3,
                            Date = new DateTime(2023, 3, 30, 4, 56, 34, 342, DateTimeKind.Local).AddTicks(5297),
                            ProductId = 4,
                            StoreId = 9
                        },
                        new
                        {
                            SaleId = 10,
                            CustomerId = 10,
                            Date = new DateTime(2022, 12, 10, 16, 21, 24, 208, DateTimeKind.Local).AddTicks(6766),
                            ProductId = 4,
                            StoreId = 7
                        });
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("Name")
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Name = "Beier LLC"
                        },
                        new
                        {
                            StoreId = 2,
                            Name = "Kilback Group"
                        },
                        new
                        {
                            StoreId = 3,
                            Name = "Olson, Hammes and Haag"
                        },
                        new
                        {
                            StoreId = 4,
                            Name = "Walker LLC"
                        },
                        new
                        {
                            StoreId = 5,
                            Name = "Kassulke Group"
                        },
                        new
                        {
                            StoreId = 6,
                            Name = "Heller - Erdman"
                        },
                        new
                        {
                            StoreId = 7,
                            Name = "Powlowski and Sons"
                        },
                        new
                        {
                            StoreId = 8,
                            Name = "Beatty Group"
                        },
                        new
                        {
                            StoreId = 9,
                            Name = "Reynolds, Mante and Stamm"
                        },
                        new
                        {
                            StoreId = 10,
                            Name = "Grant - Heidenreich"
                        });
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Sale", b =>
                {
                    b.HasOne("SalesDatabase.Data.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDatabase.Data.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDatabase.Data.Models.Store", "Store")
                        .WithMany("Sales")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Product", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SalesDatabase.Data.Models.Store", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
