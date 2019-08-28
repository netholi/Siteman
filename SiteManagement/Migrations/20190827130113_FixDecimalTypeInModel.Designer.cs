﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteManagement.DbLayer;

namespace SiteManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190827130113_FixDecimalTypeInModel")]
    partial class FixDecimalTypeInModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiteManagement.Models.Labour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<float>("Wage");

                    b.HasKey("Id");

                    b.ToTable("labours");
                });

            modelBuilder.Entity("SiteManagement.Models.LabourExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<float>("Day");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<int>("LabourId");

                    b.Property<int>("SiteId");

                    b.Property<decimal>("Wage")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("LabourId");

                    b.HasIndex("SiteId");

                    b.ToTable("LabourExpenses");
                });

            modelBuilder.Entity("SiteManagement.Models.LabourReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Dscription")
                        .HasMaxLength(250);

                    b.Property<int>("LabourId");

                    b.HasKey("Id");

                    b.ToTable("labourReceipts");
                });

            modelBuilder.Entity("SiteManagement.Models.MaterialExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<int>("LabourId");

                    b.Property<string>("Particular")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("SiteId");

                    b.HasKey("Id");

                    b.HasIndex("LabourId");

                    b.HasIndex("SiteId");

                    b.ToTable("MaterialExpenses");
                });

            modelBuilder.Entity("SiteManagement.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("email");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("SiteManagement.Models.LabourExpense", b =>
                {
                    b.HasOne("SiteManagement.Models.Labour", "Labour")
                        .WithMany("LabourExpenses")
                        .HasForeignKey("LabourId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiteManagement.Models.Site", "Site")
                        .WithMany("LabourExpenses")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SiteManagement.Models.MaterialExpense", b =>
                {
                    b.HasOne("SiteManagement.Models.Labour", "Labour")
                        .WithMany()
                        .HasForeignKey("LabourId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SiteManagement.Models.Site", "Site")
                        .WithMany("MaterialExpenses")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}