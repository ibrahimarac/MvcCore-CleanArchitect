﻿// <auto-generated />
using System;
using Ibrahim.Data.Sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ibrahim.Data.Sql.Migrations
{
    [DbContext(typeof(IlknurContext))]
    [Migration("20210530111932_ErrorRequestTypeChanged")]
    partial class ErrorRequestTypeChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ibrahim.Core.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("LastupDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("LastupUser")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 5, 30, 14, 19, 31, 467, DateTimeKind.Local).AddTicks(5907),
                            CreateUser = "admin",
                            LastupDate = new DateTime(2021, 5, 30, 14, 19, 31, 468, DateTimeKind.Local).AddTicks(5660),
                            LastupUser = "admin",
                            Name = "Kategori 1"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 5, 30, 14, 19, 31, 468, DateTimeKind.Local).AddTicks(6287),
                            CreateUser = "admin",
                            LastupDate = new DateTime(2021, 5, 30, 14, 19, 31, 468, DateTimeKind.Local).AddTicks(6293),
                            LastupUser = "admin",
                            Name = "Kategori 2"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 5, 30, 14, 19, 31, 468, DateTimeKind.Local).AddTicks(6295),
                            CreateUser = "admin",
                            LastupDate = new DateTime(2021, 5, 30, 14, 19, 31, 468, DateTimeKind.Local).AddTicks(6297),
                            LastupUser = "admin",
                            Name = "Kategori 3"
                        });
                });

            modelBuilder.Entity("Ibrahim.Core.Domain.Entities.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("IsAjaxRequest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.Property<string>("QueryString")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("200");

                    b.Property<int>("RequestType")
                        .HasColumnType("int");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Errors");
                });
#pragma warning restore 612, 618
        }
    }
}
