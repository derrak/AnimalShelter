using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AnimalSpecies = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    AnimalBreed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalBreed", "AnimalName", "AnimalSpecies", "Availability", "DateCreated", "DateModified", "Description", "UserId" },
                values: new object[,]
                {
                    { 1, "Unknown", "Yanaba", "Polar Bear", true, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(7090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afraid of shoes", 4 },
                    { 2, "Unknown", "Meg", "Giant Panda", true, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toilet trained", 3 },
                    { 3, "Unknown", "Goldie", "Amur Leopard", true, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can't sit still", 3 },
                    { 4, "Unknown", "Kendrick", "Orangutan", true, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Really messy roommate", 2 },
                    { 5, "Unknown", "Angie", "Sea Turtle", true, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thinks they're a cat", 1 },
                    { 6, "Unknown", "Theodore", "Chimpanzee", true, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good snuggles", 4 },
                    { 7, "Unknown", "Eggy", "Elephant", false, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demands to sleep in bed with humans", 1 },
                    { 8, "Unknown", "Gerald", "Plains Bison", false, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loves giving wet kisses", 5 },
                    { 9, "Unknown", "Gavr", "Vaquita", false, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 of 10 left in the world", 6 },
                    { 10, "Unknown", "Wagyu", "Rhino", false, new DateTime(2022, 8, 19, 13, 1, 7, 679, DateTimeKind.Local).AddTicks(9850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loves to nuzzle", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
