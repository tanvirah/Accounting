﻿// <auto-generated />
using System;
using AccountingData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountingData.Migrations
{
    [DbContext(typeof(AccountingContext))]
    [Migration("20191107101943_account_table_updated")]
    partial class account_table_updated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountingData.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNo");

                    b.Property<string>("AccountTitle");

                    b.Property<int?>("AccountTypeId");

                    b.Property<decimal>("CrBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DrBalance")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("AccountingData.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNature");

                    b.Property<string>("AccountTypeName");

                    b.HasKey("Id");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("AccountingData.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountsId");

                    b.Property<decimal>("Cr")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Dr")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SerialNo");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int?>("VoucherId");

                    b.HasKey("Id");

                    b.HasIndex("AccountsId");

                    b.HasIndex("VoucherId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("AccountingData.Models.Voucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("VoucherDate");

                    b.Property<int>("VoucherNo");

                    b.HasKey("Id");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("AccountingData.Models.Account", b =>
                {
                    b.HasOne("AccountingData.Models.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId");
                });

            modelBuilder.Entity("AccountingData.Models.Transaction", b =>
                {
                    b.HasOne("AccountingData.Models.Account", "Accounts")
                        .WithMany()
                        .HasForeignKey("AccountsId");

                    b.HasOne("AccountingData.Models.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("VoucherId");
                });
#pragma warning restore 612, 618
        }
    }
}