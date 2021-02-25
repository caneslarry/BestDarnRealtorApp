using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDarnRealtorApp.Migrations
{
    public partial class migrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Listing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mls = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesPrice = table.Column<float>(type: "real", nullable: false),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bedrooms = table.Column<float>(type: "real", nullable: false),
                    Bathrooms = table.Column<float>(type: "real", nullable: false),
                    GarageSize = table.Column<int>(type: "int", nullable: false),
                    SquareFeet = table.Column<int>(type: "int", nullable: false),
                    LotSize = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listing", x => x.Id);
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listing");

        
        }
    }
}
