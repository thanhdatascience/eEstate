﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using eEstate;

namespace eEstate.Migrations
{
    [DbContext(typeof(SpatialSample.SpatialDbContext))]
    partial class SpatialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eEstate.Entities.TouristAttraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Juridical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Point>("Location")
                        .HasColumnType("geometry");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostingDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TouristAttractions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 100m,
                            Direction = "In front of the door",
                            Juridical = "Ruled",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (27.175015 78.042155)"),
                            Name = "Taj Mahal",
                            PostingDate = new DateTime(2020, 5, 5, 16, 11, 28, 176, DateTimeKind.Local).AddTicks(1743),
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Area = 100m,
                            Direction = "In front of the door",
                            Juridical = "Ruled",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.61998 74.876485)"),
                            Name = "The Golden Temple of Amritsar",
                            PostingDate = new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1335),
                            Price = 10m
                        },
                        new
                        {
                            Id = 3,
                            Area = 100m,
                            Direction = "In front of the door",
                            Juridical = "Ruled",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.656159 77.24102)"),
                            Name = "The Red Fort, New Delhi",
                            PostingDate = new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1381),
                            Price = 10m
                        },
                        new
                        {
                            Id = 4,
                            Area = 100m,
                            Direction = "In front of the door",
                            Juridical = "Ruled",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (18.921984 72.834654)"),
                            Name = "The Gateway of India, Mumbai",
                            PostingDate = new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1387),
                            Price = 10m
                        },
                        new
                        {
                            Id = 5,
                            Area = 100m,
                            Direction = "In front of the door",
                            Juridical = "Ruled",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (12.305025 76.655753)"),
                            Name = "Mysore Palace",
                            PostingDate = new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1391),
                            Price = 10m
                        },
                        new
                        {
                            Id = 6,
                            Area = 100m,
                            Direction = "In front of the door",
                            Juridical = "Ruled",
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.524475 77.185521)"),
                            Name = "Qutb Minar",
                            PostingDate = new DateTime(2020, 5, 5, 16, 11, 28, 177, DateTimeKind.Local).AddTicks(1396),
                            Price = 10m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
