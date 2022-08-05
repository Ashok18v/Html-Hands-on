﻿// <auto-generated />
using System;
using ApiAndDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiAndDatabase.Data.Migrations
{
    [DbContext(typeof(DBContextBooks))]
    [Migration("20220805064609_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiAndDatabase.Entities.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("Varchar(8)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("Varchar(Max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zoner")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ApiAndDatabase.Entities.Cart", b =>
                {
                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("Varchar(8)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("Varchar(Max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zoner")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.ToTable("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
