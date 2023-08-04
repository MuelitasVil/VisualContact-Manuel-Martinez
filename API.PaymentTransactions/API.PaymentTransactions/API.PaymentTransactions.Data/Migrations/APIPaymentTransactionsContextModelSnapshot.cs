﻿// <auto-generated />
using System;
using API.PaymentTransactions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.PaymentTransactions.Data.Migrations
{
    [DbContext(typeof(APIPaymentTransactionsContext))]
    partial class APIPaymentTransactionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.PaymentTransactions.Shared.Count", b =>
                {
                    b.Property<long>("countId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("countId"), 1L, 1);

                    b.Property<long>("Total")
                        .HasColumnType("bigint");

                    b.Property<bool>("allowPartial")
                        .HasColumnType("bit");

                    b.Property<int>("currency")
                        .HasColumnType("int");

                    b.Property<bool>("paid")
                        .HasColumnType("bit");

                    b.Property<long>("payerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("suscribe")
                        .HasColumnType("bit");

                    b.HasKey("countId");

                    b.ToTable("Counts");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Field", b =>
                {
                    b.Property<long>("fieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("fieldId"), 1L, 1);

                    b.Property<long>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("displayON")
                        .HasColumnType("bit");

                    b.Property<long>("fieldsId")
                        .HasColumnType("bigint");

                    b.Property<string>("keyWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fieldId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Fields", b =>
                {
                    b.Property<long>("FieldsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FieldsId"), 1L, 1);

                    b.HasKey("FieldsId");

                    b.ToTable("ListOfFields");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Mount", b =>
                {
                    b.Property<long>("MountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MountId"), 1L, 1);

                    b.Property<long>("countId")
                        .HasColumnType("bigint");

                    b.Property<double>("factor")
                        .HasColumnType("float");

                    b.Property<int>("fromCurrency")
                        .HasColumnType("int");

                    b.Property<long>("fromTotal")
                        .HasColumnType("bigint");

                    b.Property<int>("toCurrency")
                        .HasColumnType("int");

                    b.Property<long>("toTotal")
                        .HasColumnType("bigint");

                    b.HasKey("MountId");

                    b.ToTable("Mounts");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Payer", b =>
                {
                    b.Property<long>("PayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PayerId"), 1L, 1);

                    b.Property<int>("documentType")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PayerId");

                    b.ToTable("Payers");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Payment", b =>
                {
                    b.Property<long>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("paymentId"), 1L, 1);

                    b.Property<long>("countId")
                        .HasColumnType("bigint");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("mountId")
                        .HasColumnType("bigint");

                    b.Property<long>("statusId")
                        .HasColumnType("bigint");

                    b.HasKey("paymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Receipt", b =>
                {
                    b.Property<long>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReceiptId"), 1L, 1);

                    b.Property<long>("authorization")
                        .HasColumnType("bigint");

                    b.Property<long>("fieldsId")
                        .HasColumnType("bigint");

                    b.Property<int>("franchise")
                        .HasColumnType("int");

                    b.Property<int>("issuerName")
                        .HasColumnType("int");

                    b.Property<long>("payerId")
                        .HasColumnType("bigint");

                    b.Property<long>("paymentId")
                        .HasColumnType("bigint");

                    b.Property<int>("paymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceiptId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.RequesByCount", b =>
                {
                    b.Property<long>("RequesByCountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RequesByCountId"), 1L, 1);

                    b.Property<long>("CountId")
                        .HasColumnType("bigint");

                    b.Property<string>("reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("requestId")
                        .HasColumnType("bigint");

                    b.HasKey("RequesByCountId");

                    b.ToTable("requesByCounts");
                });

            modelBuilder.Entity("API.PaymentTransactions.Shared.Status", b =>
                {
                    b.Property<long>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("statusId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("statusId");

                    b.ToTable("statuses");
                });
#pragma warning restore 612, 618
        }
    }
}
