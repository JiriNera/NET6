using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfApp1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peopel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    HomeAddressId = table.Column<int>(type: "INTEGER", nullable: true),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peopel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peopel_Addresses_HomeAddressId",
                        column: x => x.HomeAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Znacka = table.Column<string>(type: "TEXT", nullable: true),
                    Barva = table.Column<string>(type: "TEXT", nullable: true),
                    SPZ = table.Column<string>(type: "TEXT", nullable: true),
                    KM = table.Column<double>(type: "REAL", nullable: false),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Peopel_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Peopel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_PersonId",
                table: "Cars",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Peopel_HomeAddressId",
                table: "Peopel",
                column: "HomeAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Peopel");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
