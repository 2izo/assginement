﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignement.Data;

namespace assignement.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211110133331_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("assignement.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerGender")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
