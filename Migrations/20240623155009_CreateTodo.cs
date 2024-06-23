using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskApis.Migrations
{
    /// <inheritdoc />
    public partial class CreateTodo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "EndDateTime", "Title" },
                values: new object[,]
                {
                    { new Guid("ebaadb4a-cfe3-4aee-b4e1-228bb094ba5a"), "Buy gorceries", new DateTime(2024, 6, 28, 15, 50, 9, 336, DateTimeKind.Utc).AddTicks(8160), "Groceries" },
                    { new Guid("f3926733-b84e-42b5-98d2-7880f525041e"), "Take a form", new DateTime(2024, 6, 25, 15, 50, 9, 336, DateTimeKind.Utc).AddTicks(8190), "Form" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
