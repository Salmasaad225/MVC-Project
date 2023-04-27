﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab3.models;

#nullable disable

namespace lab3.Migrations
{
    [DbContext(typeof(Context_DB))]
    [Migration("20230307071106_inyu")]
    partial class inyu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lab3.models.category.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Parent_CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Parent_CategoryID");

                    b.ToTable("Catigory", (string)null);
                });

            modelBuilder.Entity("lab3.models.images.Images", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Product_ID")
                        .HasColumnType("bigint");

                    b.Property<float>("Width")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("images", (string)null);
                });

            modelBuilder.Entity("lab3.models.product.Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<int?>("Available")
                        .HasColumnType("int");

                    b.Property<int>("Catigory_ID")
                        .HasColumnType("int");

                    b.Property<byte?>("Discound_persentage")
                        .HasColumnType("tinyint");

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("Catigory_ID");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("lab3.models.category.Category", b =>
                {
                    b.HasOne("lab3.models.category.Category", "Parent_Category")
                        .WithMany("Sub_Categories")
                        .HasForeignKey("Parent_CategoryID");

                    b.Navigation("Parent_Category");
                });

            modelBuilder.Entity("lab3.models.images.Images", b =>
                {
                    b.HasOne("lab3.models.product.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("lab3.models.product.Product", b =>
                {
                    b.HasOne("lab3.models.category.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("Catigory_ID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("lab3.models.category.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Sub_Categories");
                });

            modelBuilder.Entity("lab3.models.product.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
