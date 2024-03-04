using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeiliLab.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Beds = table.Column<int>(type: "int", nullable: false),
                    Guests = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CountryId", "County", "LineOne", "LineThree", "LineTwo", "PostCode" },
                values: new object[,]
                {
                    { 1, "London", 1, "Greater London", "123 Main Street", null, null, "SW1A 1AA" },
                    { 2, "Manchester", 1, "Greater Manchester", "456 Oak Avenue", null, "Apartment 5B", "M1 1AA" },
                    { 3, "Birmingham", 1, "West Midlands", "789 High Street", null, null, "B1 1AA" },
                    { 4, "Edinburgh", 2, "Midlothian", "234 Highland Avenue", null, "Suite 3C", "EH1 1AA" },
                    { 5, "Glasgow", 2, "Glasgow City", "567 Castle Road", null, null, "G1 1AA" },
                    { 6, "Aberdeen", 2, "Aberdeenshire", "890 Lochside Lane", null, "Apartment 2A", "AB1 1AA" },
                    { 7, "Cardiff", 3, "Glamorgan", "111 Welsh Street", null, null, "CF1 1AA" },
                    { 8, "Swansea", 3, "West Glamorgan", "222 Dragon Avenue", null, null, "SA1 1AA" },
                    { 9, "Wrexham", 3, "Clwyd", "333 Valley Road", null, null, "LL1 1AA" },
                    { 10, "Belfast", 4, "Antrim", "444 Belfast Lane", null, null, "BT1 1AA" },
                    { 11, "Derry", 4, "Londonderry", "555 Derry Street", null, null, "BT2 1AA" },
                    { 12, "Armagh", 4, "Armagh", "666 Armagh Road", null, null, "BT3 1AA" },
                    { 13, "Dublin", 5, "Dublin", "777 Dublin Street", null, null, "D01 1AA" },
                    { 14, "Cork", 5, "Cork", "888 Cork Avenue", null, null, "T12 1AA" },
                    { 15, "Galway", 5, "Galway", "999 Galway Road", null, null, "H91 1AA" },
                    { 16, "Paris", 6, "Ile-de-France", "101 Paris Street", null, null, "75001" },
                    { 17, "Marseille", 6, "Provence-Alpes-Côte d'Azur", "202 Marseille Avenue", null, null, "13001" },
                    { 18, "Lyon", 6, "Auvergne-Rhône-Alpes", "303 Lyon Road", null, null, "69001" },
                    { 19, "Madrid", 7, "Community of Madrid", "404 Madrid Street", null, null, "28001" },
                    { 20, "Barcelona", 7, "Catalonia", "505 Barcelona Avenue", null, null, "08001" },
                    { 21, "Valencia", 7, "Valencian Community", "606 Valencia Road", null, null, "46001" },
                    { 22, "Lisbon", 8, "Lisbon District", "707 Lisbon Street", null, null, "1000-001" },
                    { 23, "Porto", 8, "Porto District", "808 Porto Avenue", null, null, "4000-001" },
                    { 24, "Faro", 8, "Faro District", "909 Faro Road", null, null, "8000-001" },
                    { 25, "Rome", 9, "Lazio", "101 Rome Street", null, null, "00100" },
                    { 26, "Milan", 9, "Lombardy", "202 Milan Avenue", null, null, "20100" },
                    { 27, "Florence", 9, "Tuscany", "303 Florence Road", null, null, "50100" },
                    { 28, "Berlin", 10, "Berlin", "404 Berlin Street", null, null, "10115" },
                    { 29, "Hamburg", 10, "Hamburg", "505 Hamburg Avenue", null, null, "20095" },
                    { 30, "Munich", 10, "Bavaria", "606 Munich Road", null, null, "80331" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "ENG", "England" },
                    { 2, "SCT", "Scotland" },
                    { 3, "WAL", "Wales" },
                    { 4, "NIR", "Northern Ireland" },
                    { 5, "IRE", "Ireland" },
                    { 6, "FRA", "France" },
                    { 7, "ESP", "Spain" },
                    { 8, "POR", "Portugal" },
                    { 9, "ITA", "Italy" },
                    { 10, "GER", "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "AddressId", "Bathrooms", "Beds", "CountryId", "Description", "Guests", "Location", "Name", "PricePerNight", "PropertyType", "Rating", "Rooms" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, "A comfortable apartment in the heart of London.", 2, "123 Main Street, London", "Cozy Apartment in London", 100.00m, 1, 4.5, 2 },
                    { 2, 4, 2, 2, 2, "A charming cottage with beautiful views of Edinburgh.", 4, "234 Highland Avenue, Edinburgh", "Scenic Cottage in Edinburgh", 150.00m, 5, 4.7999999999999998, 3 },
                    { 3, 7, 1, 1, 3, "A peaceful retreat in the heart of Cardiff, Wales.", 2, "111 Welsh Street, Cardiff", "Welsh Retreat in Cardiff", 80.00m, 1, 4.2000000000000002, 1 },
                    { 4, 10, 3, 3, 4, "A luxurious penthouse with stunning views of Belfast.", 6, "444 Belfast Lane, Belfast", "Spacious Penthouse in Belfast", 250.00m, 10, 4.9000000000000004, 4 },
                    { 5, 13, 1, 1, 5, "Modern apartment in the heart of Dublin city center.", 2, "777 Dublin Street, Dublin", "Dublin City Center Apartment", 120.00m, 9, 4.7000000000000002, 1 },
                    { 6, 16, 1, 1, 6, "Chic studio in the heart of Paris, close to the Eiffel Tower.", 3, "101 Paris Street, Paris", "Elegant Parisian Studio", 180.00m, 0, 4.5999999999999996, 2 },
                    { 7, 20, 4, 4, 7, "A beautiful villa with a private pool near Barcelona's beaches.", 8, "505 Barcelona Avenue, Barcelona", "Seaside Villa in Barcelona", 300.00m, 0, 4.7999999999999998, 5 },
                    { 8, 22, 2, 2, 8, "Charming townhouse with traditional Portuguese architecture.", 5, "707 Lisbon Street, Lisbon", "Historic Lisbon Townhouse", 160.00m, 4, 4.5, 3 },
                    { 9, 25, 1, 1, 9, "Cozy apartment with a view of the Colosseum.", 3, "101 Rome Street, Rome", "Roman Holiday Apartment", 140.00m, 1, 4.4000000000000004, 2 },
                    { 10, 30, 2, 2, 10, "Tranquil retreat in the Bavarian countryside.", 4, "606 Munich Road, Munich", "Munich Countryside Retreat", 200.00m, 13, 4.5999999999999996, 3 },
                    { 11, 9, 1, 1, 3, "Escape to nature with this lakeside cabin in Wales.", 2, "333 Valley Road, Wrexham", "Serene Lakeside Cabin in Wales", 90.00m, 9, 4.2999999999999998, 1 },
                    { 12, 24, 3, 3, 8, "Exclusive villa with direct access to the Algarve beaches.", 6, "909 Faro Road, Faro", "Luxury Beachfront Villa in Algarve", 280.00m, 3, 4.9000000000000004, 4 },
                    { 13, 28, 1, 1, 10, "Modern loft in the heart of Berlin's vibrant city center.", 3, "404 Berlin Street, Berlin", "Berlin City Loft", 170.00m, 1, 4.7000000000000002, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CountryId",
                table: "Properties",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
