using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alphastellar_WebAPI_Project.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wheels = table.Column<int>(type: "int", nullable: false),
                    Headlights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Colour", "CreateDate", "Status" },
                values: new object[,]
                {
                    { 1, "Blue", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1693), 1 },
                    { 2, "Black", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1695), 1 },
                    { 3, "White", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1696), 1 },
                    { 4, "Red", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1697), 1 },
                    { 5, "Black", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1698), 1 }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Colour", "CreateDate", "Status" },
                values: new object[,]
                {
                    { 1, "Black", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1603), 1 },
                    { 2, "White", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1605), 1 },
                    { 3, "Red", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1606), 1 },
                    { 4, "Blue", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1607), 1 },
                    { 5, "Red", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1608), 1 },
                    { 6, "Blue", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1609), 1 },
                    { 7, "White", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1610), 1 },
                    { 8, "Black", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1611), 1 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Colour", "CreateDate", "Headlights", "Status", "Wheels" },
                values: new object[,]
                {
                    { 1, "Red", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1377), "On", 1, 4 },
                    { 2, "Blue", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1393), "Off", 1, 4 },
                    { 3, "Black", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1395), "Off", 1, 4 },
                    { 4, "White", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1396), "Off", 1, 4 },
                    { 5, "Red", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1397), "Off", 1, 4 },
                    { 6, "Blue", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1398), "On", 1, 4 },
                    { 7, "Black", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1400), "On", 1, 4 },
                    { 8, "White", new DateTime(2022, 5, 17, 16, 43, 5, 592, DateTimeKind.Local).AddTicks(1401), "Off", 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
