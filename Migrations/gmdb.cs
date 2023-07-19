using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SeedData.Models;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SeedData.Migrations
{
    /// <inheritdoc />
    public partial class gmdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Mers" },
                    { 6, "Mers" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "Mutsubity" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Ali Karimov" },
                    { 4, "Jamol Fozilov" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}









//Delete(1, dbContext.Cars);
//Update(2, "NewName", "NewMiddle", dbContext.Cars);
//Read(dbContext.Cars);
//Add(new Car { Name = "NewCar" }, dbContext.Cars);

//Delete(1, dbContext.Clients);
//Update(2, "NewName", "NewMiddle", dbContext.Clients);
//Read(dbContext.Clients);
//Add(new Client { Name = "NewClient" }, dbContext.Clients);

//Delete(1, dbContext.Buses);
//Update(2, "NewName", "NewMiddle", dbContext.Buses);
//Read(dbContext.Buses);
//Add(new Bus { Name = "NewBus" }, dbContext.Buses);




//List<Car> allCars = GetAll(dbContext.Cars);
//Car car = Get(1, dbContext.Cars);

//List<Client> allClients = GetAll(dbContext.Clients);
//Client client = Get(2, dbContext.Clients);

//List<Bus> allBuses = GetAll(dbContext.Buses);
//Bus bus = Get(3, dbContext.Buses);
