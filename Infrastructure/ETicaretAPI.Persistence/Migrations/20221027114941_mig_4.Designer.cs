﻿// <auto-generated />
using System;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    [DbContext(typeof(ETicaretAPIDbContext))]
    [Migration("20221027114941_mig_4")]
    partial class mig_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.File", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Files");

                    b.HasDiscriminator<string>("Discriminator").HasValue("File");
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<Guid>("OrdersID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrdersID", "ProductsID");

                    b.HasIndex("ProductsID");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.InvoiceFile", b =>
                {
                    b.HasBaseType("ETicaretAPI.Domain.Entities.File");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("InvoiceFile");
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.ProductImageFile", b =>
                {
                    b.HasBaseType("ETicaretAPI.Domain.Entities.File");

                    b.HasDiscriminator().HasValue("ProductImageFile");
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.Order", b =>
                {
                    b.HasOne("ETicaretAPI.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("ETicaretAPI.Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretAPI.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ETicaretAPI.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
