﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using a;

#nullable disable

namespace MIS3033_Exam1_Practice_BradenFisher.Migrations
{
    [DbContext(typeof(StudentDB))]
    [Migration("20230925134102_createdb")]
    partial class createdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("a.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<double>("grade")
                        .HasColumnType("REAL");

                    b.Property<int>("gradeLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("stuTbl");
                });
#pragma warning restore 612, 618
        }
    }
}