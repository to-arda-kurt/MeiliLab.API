using MeiliLab.API.Models.Database;
using MeiliLab.API.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace MeiliLab.API.Context
{
    public class MeiliLabDbContext : DbContext
    {
        public MeiliLabDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Property> Properties { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Country>()
                .HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "England",
                        Code = "ENG"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Scotland",
                        Code = "SCT"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Wales",
                        Code = "WAL"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "Northern Ireland",
                        Code = "NIR"
                    },
                    new Country
                    {
                        Id = 5,
                        Name = "Ireland",
                        Code = "IRE"
                    },
                    new Country
                    {
                        Id = 6,
                        Name = "France",
                        Code = "FRA"
                    },
                    new Country
                    {
                        Id = 7,
                        Name = "Spain",
                        Code = "ESP"
                    },
                    new Country
                    {
                        Id = 8,
                        Name = "Portugal",
                        Code = "POR"
                    },
                    new Country
                    {
                        Id = 9,
                        Name = "Italy",
                        Code = "ITA"
                    },
                    new Country
                    {
                        Id = 10,
                        Name = "Germany",
                        Code = "GER"
                    }
                );

            modelBuilder
                .Entity<Address>()
                .HasData(
                    new Address
                    {
                        Id = 1,
                        LineOne = "123 Main Street",
                        City = "London",
                        County = "Greater London",
                        PostCode = "SW1A 1AA",
                        CountryId = 1
                    },
                    new Address
                    {
                        Id = 2,
                        LineOne = "456 Oak Avenue",
                        LineTwo = "Apartment 5B",
                        City = "Manchester",
                        County = "Greater Manchester",
                        PostCode = "M1 1AA",
                        CountryId = 1
                    },
                    new Address
                    {
                        Id = 3,
                        LineOne = "789 High Street",
                        City = "Birmingham",
                        County = "West Midlands",
                        PostCode = "B1 1AA",
                        CountryId = 1
                    },
                    new Address
                    {
                        Id = 4,
                        LineOne = "234 Highland Avenue",
                        LineTwo = "Suite 3C",
                        City = "Edinburgh",
                        County = "Midlothian",
                        PostCode = "EH1 1AA",
                        CountryId = 2
                    },
                    new Address
                    {
                        Id = 5,
                        LineOne = "567 Castle Road",
                        City = "Glasgow",
                        County = "Glasgow City",
                        PostCode = "G1 1AA",
                        CountryId = 2
                    },
                    new Address
                    {
                        Id = 6,
                        LineOne = "890 Lochside Lane",
                        LineTwo = "Apartment 2A",
                        City = "Aberdeen",
                        County = "Aberdeenshire",
                        PostCode = "AB1 1AA",
                        CountryId = 2
                    },
                    new Address
                    {
                        Id = 7,
                        LineOne = "111 Welsh Street",
                        City = "Cardiff",
                        County = "Glamorgan",
                        PostCode = "CF1 1AA",
                        CountryId = 3
                    },
                    new Address
                    {
                        Id = 8,
                        LineOne = "222 Dragon Avenue",
                        City = "Swansea",
                        County = "West Glamorgan",
                        PostCode = "SA1 1AA",
                        CountryId = 3
                    },
                    new Address
                    {
                        Id = 9,
                        LineOne = "333 Valley Road",
                        City = "Wrexham",
                        County = "Clwyd",
                        PostCode = "LL1 1AA",
                        CountryId = 3
                    },
                    new Address
                    {
                        Id = 10,
                        LineOne = "444 Belfast Lane",
                        City = "Belfast",
                        County = "Antrim",
                        PostCode = "BT1 1AA",
                        CountryId = 4
                    },
                    new Address
                    {
                        Id = 11,
                        LineOne = "555 Derry Street",
                        City = "Derry",
                        County = "Londonderry",
                        PostCode = "BT2 1AA",
                        CountryId = 4
                    },
                    new Address
                    {
                        Id = 12,
                        LineOne = "666 Armagh Road",
                        City = "Armagh",
                        County = "Armagh",
                        PostCode = "BT3 1AA",
                        CountryId = 4
                    },
                    new Address
                    {
                        Id = 13,
                        LineOne = "777 Dublin Street",
                        City = "Dublin",
                        County = "Dublin",
                        PostCode = "D01 1AA",
                        CountryId = 5
                    },
                    new Address
                    {
                        Id = 14,
                        LineOne = "888 Cork Avenue",
                        City = "Cork",
                        County = "Cork",
                        PostCode = "T12 1AA",
                        CountryId = 5
                    },
                    new Address
                    {
                        Id = 15,
                        LineOne = "999 Galway Road",
                        City = "Galway",
                        County = "Galway",
                        PostCode = "H91 1AA",
                        CountryId = 5
                    },
                    new Address
                    {
                        Id = 16,
                        LineOne = "101 Paris Street",
                        City = "Paris",
                        County = "Ile-de-France",
                        PostCode = "75001",
                        CountryId = 6
                    },
                    new Address
                    {
                        Id = 17,
                        LineOne = "202 Marseille Avenue",
                        City = "Marseille",
                        County = "Provence-Alpes-Côte d'Azur",
                        PostCode = "13001",
                        CountryId = 6
                    },
                    new Address
                    {
                        Id = 18,
                        LineOne = "303 Lyon Road",
                        City = "Lyon",
                        County = "Auvergne-Rhône-Alpes",
                        PostCode = "69001",
                        CountryId = 6
                    },
                    new Address
                    {
                        Id = 19,
                        LineOne = "404 Madrid Street",
                        City = "Madrid",
                        County = "Community of Madrid",
                        PostCode = "28001",
                        CountryId = 7
                    },
                    new Address
                    {
                        Id = 20,
                        LineOne = "505 Barcelona Avenue",
                        City = "Barcelona",
                        County = "Catalonia",
                        PostCode = "08001",
                        CountryId = 7
                    },
                    new Address
                    {
                        Id = 21,
                        LineOne = "606 Valencia Road",
                        City = "Valencia",
                        County = "Valencian Community",
                        PostCode = "46001",
                        CountryId = 7
                    },
                    new Address
                    {
                        Id = 22,
                        LineOne = "707 Lisbon Street",
                        City = "Lisbon",
                        County = "Lisbon District",
                        PostCode = "1000-001",
                        CountryId = 8
                    },
                    new Address
                    {
                        Id = 23,
                        LineOne = "808 Porto Avenue",
                        City = "Porto",
                        County = "Porto District",
                        PostCode = "4000-001",
                        CountryId = 8
                    },
                    new Address
                    {
                        Id = 24,
                        LineOne = "909 Faro Road",
                        City = "Faro",
                        County = "Faro District",
                        PostCode = "8000-001",
                        CountryId = 8
                    },
                    new Address
                    {
                        Id = 25,
                        LineOne = "101 Rome Street",
                        City = "Rome",
                        County = "Lazio",
                        PostCode = "00100",
                        CountryId = 9
                    },
                    new Address
                    {
                        Id = 26,
                        LineOne = "202 Milan Avenue",
                        City = "Milan",
                        County = "Lombardy",
                        PostCode = "20100",
                        CountryId = 9
                    },
                    new Address
                    {
                        Id = 27,
                        LineOne = "303 Florence Road",
                        City = "Florence",
                        County = "Tuscany",
                        PostCode = "50100",
                        CountryId = 9
                    },
                    new Address
                    {
                        Id = 28,
                        LineOne = "404 Berlin Street",
                        City = "Berlin",
                        County = "Berlin",
                        PostCode = "10115",
                        CountryId = 10
                    },
                    new Address
                    {
                        Id = 29,
                        LineOne = "505 Hamburg Avenue",
                        City = "Hamburg",
                        County = "Hamburg",
                        PostCode = "20095",
                        CountryId = 10
                    },
                    new Address
                    {
                        Id = 30,
                        LineOne = "606 Munich Road",
                        City = "Munich",
                        County = "Bavaria",
                        PostCode = "80331",
                        CountryId = 10
                    }
                );

            modelBuilder
                .Entity<Property>()
                .HasData(
                    new Property
                    {
                        Id = 1,
                        Name = "Cozy Apartment in London",
                        Location = "123 Main Street, London",
                        Description = "A comfortable apartment in the heart of London.",
                        Rooms = 2,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 2,
                        Rating = 4.5,
                        PricePerNight = 100.00m,
                        AddressId = 1,
                        CountryId = 1,
                        PropertyType = PropertyType.Apartment,
                    },
                    new Property
                    {
                        Id = 2,
                        Name = "Scenic Cottage in Edinburgh",
                        Location = "234 Highland Avenue, Edinburgh",
                        Description = "A charming cottage with beautiful views of Edinburgh.",
                        Rooms = 3,
                        Bathrooms = 2,
                        Beds = 2,
                        Guests = 4,
                        Rating = 4.8,
                        PricePerNight = 150.00m,
                        AddressId = 4,
                        CountryId = 2,
                        PropertyType = PropertyType.Cottage,
                    },
                    new Property
                    {
                        Id = 3,
                        Name = "Welsh Retreat in Cardiff",
                        Location = "111 Welsh Street, Cardiff",
                        Description = "A peaceful retreat in the heart of Cardiff, Wales.",
                        Rooms = 1,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 2,
                        Rating = 4.2,
                        PricePerNight = 80.00m,
                        AddressId = 7,
                        CountryId = 3,
                        PropertyType = PropertyType.Apartment,
                    },
                    new Property
                    {
                        Id = 4,
                        Name = "Spacious Penthouse in Belfast",
                        Location = "444 Belfast Lane, Belfast",
                        Description = "A luxurious penthouse with stunning views of Belfast.",
                        Rooms = 4,
                        Bathrooms = 3,
                        Beds = 3,
                        Guests = 6,
                        Rating = 4.9,
                        PricePerNight = 250.00m,
                        AddressId = 10,
                        CountryId = 4,
                        PropertyType = PropertyType.Mansion,
                    },
                    new Property
                    {
                        Id = 5,
                        Name = "Dublin City Center Apartment",
                        Location = "777 Dublin Street, Dublin",
                        Description = "Modern apartment in the heart of Dublin city center.",
                        Rooms = 1,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 2,
                        Rating = 4.7,
                        PricePerNight = 120.00m,
                        AddressId = 13,
                        CountryId = 5,
                        PropertyType = PropertyType.Cabin,
                    },
                    new Property
                    {
                        Id = 6,
                        Name = "Elegant Parisian Studio",
                        Location = "101 Paris Street, Paris",
                        Description =
                            "Chic studio in the heart of Paris, close to the Eiffel Tower.",
                        Rooms = 2,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 3,
                        Rating = 4.6,
                        PricePerNight = 180.00m,
                        AddressId = 16,
                        CountryId = 6,
                        PropertyType = PropertyType.House,
                    },
                    new Property
                    {
                        Id = 7,
                        Name = "Seaside Villa in Barcelona",
                        Location = "505 Barcelona Avenue, Barcelona",
                        Description =
                            "A beautiful villa with a private pool near Barcelona's beaches.",
                        Rooms = 5,
                        Bathrooms = 4,
                        Beds = 4,
                        Guests = 8,
                        Rating = 4.8,
                        PricePerNight = 300.00m,
                        AddressId = 20,
                        CountryId = 7,
                        PropertyType = PropertyType.House
                    },
                    new Property
                    {
                        Id = 8,
                        Name = "Historic Lisbon Townhouse",
                        Location = "707 Lisbon Street, Lisbon",
                        Description =
                            "Charming townhouse with traditional Portuguese architecture.",
                        Rooms = 3,
                        Bathrooms = 2,
                        Beds = 2,
                        Guests = 5,
                        Rating = 4.5,
                        PricePerNight = 160.00m,
                        AddressId = 22,
                        CountryId = 8,
                        PropertyType = PropertyType.Townhouse
                    },
                    new Property
                    {
                        Id = 9,
                        Name = "Roman Holiday Apartment",
                        Location = "101 Rome Street, Rome",
                        Description = "Cozy apartment with a view of the Colosseum.",
                        Rooms = 2,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 3,
                        Rating = 4.4,
                        PricePerNight = 140.00m,
                        AddressId = 25,
                        CountryId = 9,
                        PropertyType = PropertyType.Apartment
                    },
                    new Property
                    {
                        Id = 10,
                        Name = "Munich Countryside Retreat",
                        Location = "606 Munich Road, Munich",
                        Description = "Tranquil retreat in the Bavarian countryside.",
                        Rooms = 3,
                        Bathrooms = 2,
                        Beds = 2,
                        Guests = 4,
                        Rating = 4.6,
                        PricePerNight = 200.00m,
                        AddressId = 30,
                        CountryId = 10,
                        PropertyType = PropertyType.Farmhouse
                    },
                    new Property
                    {
                        Id = 11,
                        Name = "Serene Lakeside Cabin in Wales",
                        Location = "333 Valley Road, Wrexham",
                        Description = "Escape to nature with this lakeside cabin in Wales.",
                        Rooms = 1,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 2,
                        Rating = 4.3,
                        PricePerNight = 90.00m,
                        AddressId = 9,
                        CountryId = 3,
                        PropertyType = PropertyType.Cabin
                    },
                    new Property
                    {
                        Id = 12,
                        Name = "Luxury Beachfront Villa in Algarve",
                        Location = "909 Faro Road, Faro",
                        Description = "Exclusive villa with direct access to the Algarve beaches.",
                        Rooms = 4,
                        Bathrooms = 3,
                        Beds = 3,
                        Guests = 6,
                        Rating = 4.9,
                        PricePerNight = 280.00m,
                        AddressId = 24,
                        CountryId = 8,
                        PropertyType = PropertyType.Villa

                    },
                    new Property
                    {
                        Id = 13,
                        Name = "Berlin City Loft",
                        Location = "404 Berlin Street, Berlin",
                        Description = "Modern loft in the heart of Berlin's vibrant city center.",
                        Rooms = 2,
                        Bathrooms = 1,
                        Beds = 1,
                        Guests = 3,
                        Rating = 4.7,
                        PricePerNight = 170.00m,
                        AddressId = 28,
                        CountryId = 10,
                        PropertyType = PropertyType.Apartment
                    }
                );
        }
    }
}
