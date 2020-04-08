using eEstate.Entities;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEstate
{
    public class SpatialSample
    {
        public class SpatialDbContext : DbContext
        {
            public DbSet<TouristAttraction> TouristAttractions { get; set; }

            public SpatialDbContext(DbContextOptions options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

                modelBuilder.Entity<TouristAttraction>()
                    .HasData(
                        new TouristAttraction
                        {
                            Id = 1,
                            Name = "Taj Mahal",
                            Location = geometryFactory.CreatePoint(new Coordinate(27.175015, 78.042155)),
                            Price = 10,
                            Area = 100,
                            PostingDate = DateTime.Now,
                            Juridical = "Ruled",
                            Direction = "In front of the door"

                        },
                        new TouristAttraction
                        {
                            Id = 2,
                            Name = "The Golden Temple of Amritsar",
                            Location = geometryFactory.CreatePoint(new Coordinate(31.619980, 74.876485)),
                            Price = 10,
                            Area = 100,
                            PostingDate = DateTime.Now,
                            Juridical = "Ruled",
                            Direction = "In front of the door"
                        },
                        new TouristAttraction
                        {
                            Id = 3,
                            Name = "The Red Fort, New Delhi",
                            Location = geometryFactory.CreatePoint(new Coordinate(28.656159, 77.241020)),
                            Price = 10,
                            Area = 100,
                            PostingDate = DateTime.Now,
                            Juridical = "Ruled",
                            Direction = "In front of the door"
                        },
                        new TouristAttraction
                        {
                            Id = 4,
                            Name = "The Gateway of India, Mumbai",
                            Location = geometryFactory.CreatePoint(new Coordinate(18.921984, 72.834654)),
                            Price = 10,
                            Area = 100,
                            PostingDate = DateTime.Now,
                            Juridical = "Ruled",
                            Direction = "In front of the door"
                        },
                        new TouristAttraction
                        {
                            Id = 5,
                            Name = "Mysore Palace",
                            Location = geometryFactory.CreatePoint(new Coordinate(12.305025, 76.655753)),
                            Price = 10,
                            Area = 100,
                            PostingDate = DateTime.Now,
                            Juridical = "Ruled",
                            Direction = "In front of the door"
                        },
                        new TouristAttraction
                        {
                            Id = 6,
                            Name = "Qutb Minar",
                            Location = geometryFactory.CreatePoint(new Coordinate(28.524475, 77.185521)),
                            Price = 10,
                            Area = 100,
                            PostingDate = DateTime.Now,
                            Juridical = "Ruled",
                            Direction = "In front of the door"
                        }
                    );
            }
        }
    }
}
