using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "INDIA",
                    ShortName = "IND"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "PAKISTAN",
                     ShortName = "PAK"
                 },
                  new Country
                  {
                      Id = 3,
                      Name = "ENGLAND",
                      ShortName = "ENG"
                  }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Jameka",
                    Address = "Mukhed",
                    CountryId = 1,
                    Rating = 1.1
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Jameka2",
                     Address = "Mukhed2",
                     CountryId = 2,
                     Rating = 1.1
                 },
                 
                  new Hotel
                  {
                      Id = 3,
                      Name = "Jameka3",
                      Address = "Mukhed3",
                      CountryId = 3,
                      Rating = 3.2
                  },
                  new Hotel
                  {
                      Id = 4,
                      Name = "Jameka4",
                      Address = "Mukhed4",
                      CountryId = 3,
                      Rating = 4.1
                  }
                );

        }
    }
}
